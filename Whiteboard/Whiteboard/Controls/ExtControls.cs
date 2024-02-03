using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Whiteboard.Util;

namespace Whiteboard
{
    public interface IXControl
    {
        IXControl? IXParent { get; }
        Point Offset { get; }
        void Zoom(float scale);
        void Pan(int dx, int dy);
        void SetPosition(int x, int y);
        void Init();
    }

    public class XCNode : Button, IXControl
    {
        public IXControl? IXParent { get; private set; }
        public Point LastMousePosition { get; set; }
        public Point Offset { get; set; }
        private Point LastDelta { get; set; }
        public Point BaseDim { get; set; }
        public bool Drag { get; set; }

        public XCNode()
        {
            Drag = false;
        }

        public void Init()
        {
            BaseDim = new Point(Size.Width, Size.Height);
            IXParent = Parent is IXControl control ? control : null;
            Offset = Location;
        }

        public void SetPosition(int x, int y)
        {
            Location = new Point(x, y);
        }

        public void Zoom(float scale)
        {
            if (scale > 0.2f)
            {
                Width = (int)(BaseDim.X * scale);
                Height = (int)(BaseDim.Y * scale);
            }
            var pOffset = Parent is IXControl p ? p.Offset : new Point();
            var rawDist = GeomHelper.Dist(Offset, pOffset);
            var angle = GeomHelper.Angle(Offset, pOffset);
            var nPos = GeomHelper.ADToCoord(angle, rawDist * scale);
            Location = nPos.Add(pOffset);
        }

        public void Pan(int dx, int dy)
        {
            var dxy = new Point(dx, dy);
            Offset = Offset.Add(dxy);
            Location = new Point(Location.X + dxy.X, Location.Y + dxy.Y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grPath);
            base.OnPaint(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Drag = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Drag = true;
            LastMousePosition = e.Location;
            LastDelta = new(0, 0);
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Drag)
            {
                var diff = new Point(
                    e.Location.X - LastMousePosition.X + LastDelta.X,
                    e.Location.Y - LastMousePosition.Y + LastDelta.Y);
                Pan(diff.X, diff.Y);
                LastMousePosition = e.Location;
                LastDelta = diff;
            }

            base.OnMouseMove(e);
        }
    }

    public class XCPanel : Panel, IXControl
    {
        public Button follow;
        public IXControl? IXParent { get; private set; }
        public Point Offset { get; set; }
        private Point LastPosition;
        private bool Drag { get; set; }
        private float CurrScale { get; set; }
        const float SCALE_CONST = 0.05f;

        public XCPanel()
        {
            LastPosition = new Point(0, 0);
            Drag = false;
            CurrScale = 1f;
            follow = new Button();
            follow.Size = new Size(30, 30);
            follow.BackColor = Color.Black;
            follow.Location = Offset;
            follow.Text = "CRN";
            follow.UseVisualStyleBackColor = true;
            //Controls.Add(follow);
        }

        public void Init()
        {
            IXParent = Parent is IXControl control ? control : null;
            foreach (var ctrl in Controls)
            {
                if (ctrl is not IXControl) { continue; }
                ((IXControl)ctrl).Init();
            }
        }

        public void Pan(int dx, int dy)
        {
            if (!Drag) { return; }
            var dxy = new Point((int)dx, (int)dy);
            Offset = Offset.Add(dxy);
            Debug.WriteLine($"{Offset}");
            foreach (var ctrl in Controls)
            {
                if (ctrl is not IXControl) { continue; }
                ((IXControl)ctrl).Pan(dx, dy);
            }
        }

        public void Zoom(float amount)
        {
            CurrScale = Math.Clamp(CurrScale + amount, 0.1f, 5f);
            Debug.WriteLine($"SCALE: {CurrScale}");
            foreach (var r_ctrl in Controls)
            {
                if (r_ctrl is not IXControl) { continue; }
                var ctrl = (IXControl)r_ctrl;
                ctrl.Zoom(CurrScale);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Drag = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            LastPosition = e.Location;
            Drag = true;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var diff = new Point(
                e.Location.X - LastPosition.X, 
                e.Location.Y - LastPosition.Y);
            Pan(diff.X, diff.Y);
            LastPosition = e.Location;
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Drag = false;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Zoom((e.Delta / 120) * SCALE_CONST);
            base.OnMouseWheel(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        public void SetPosition(int x, int y)
        {
            Offset = new Point(x, y);
        }
    }
}
