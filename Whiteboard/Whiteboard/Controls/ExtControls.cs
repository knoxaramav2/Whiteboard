using System.Diagnostics;
using System.Drawing.Drawing2D;
using Whiteboard.Util;

namespace Whiteboard.Controls
{
    public interface IXControl
    {
        List<IXControl> FwdNodes { get; }
        bool Contains(IXControl control);
        IXControl? IXParent { get; }
        Point Offset { get; }
        void Zoom(float scale);
        void Pan(int dx, int dy);
        void SetPosition(int x, int y);
        void Init();
    }

    public interface IXContainer
    {
        IXControl? Selected { get; }
        void SetSelected(IXControl selection);
        void UpdateDraw();
    }

    public class XCNode : Button, IXControl
    {
        public IXControl? IXParent { get; private set; }
        public Point LastMousePosition { get; set; }
        public Point Offset { get; set; }
        private Point LastDelta { get; set; }
        public Point BaseDim { get; set; }
        public bool Drag { get; set; }

        public List<IXControl> FwdNodes { get; private set; }

        public XCNode()
        {
            Drag = false;
            FwdNodes = [];
        }

        public void Init()
        {
            BaseDim = new Point(Size.Width, Size.Height);
            IXParent = Parent is IXControl control ? control : null;
            Offset = Location;
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
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
            Region = new Region(grPath);
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

            if (Parent is IXContainer parent) { parent.SetSelected(this); }

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
                if (Parent is IXContainer cxpar) { cxpar.UpdateDraw(); }
            }

            base.OnMouseMove(e);
        }

        public bool Contains(IXControl control)
        {
            return FwdNodes.Contains(control);
        }
    }

    public class XCPanel : Panel, IXControl, IXContainer
    {
        private Bitmap BMBuffer;
        private Graphics GBuffer;
        public Button follow;
        public IXControl? IXParent { get; private set; }
        public Point Offset { get; set; }
        private Point LastPosition;
        private bool Drag { get; set; }
        private float CurrScale { get; set; }
        public IXControl? Selected { get; private set; }
        public List<IXControl> FwdNodes { get; set; }
        const float SCALE_CONST = 0.05f;

        public XCPanel()
        {
            LastPosition = new Point(0, 0);
            Selected = null;
            Drag = false;
            CurrScale = 1f;
            DoubleBuffered = true;
            BMBuffer = new(1, 1);
            GBuffer = Graphics.FromImage(BMBuffer);
            FwdNodes = [];

            follow = new Button
            {
                Size = new Size(30, 30),
                BackColor = Color.Black,
                Location = Offset,
                Text = "CRN",
                UseVisualStyleBackColor = true
            };
        }

        public void Init()
        {
            IXParent = Parent is IXControl control ? control : null;
            BMBuffer = new Bitmap(Width, Height);
            GBuffer = Graphics.FromImage(BMBuffer);
            GBuffer.Clear(Color.Transparent);
            foreach (var ctrl in Controls)
            {
                if (ctrl is not IXControl) { continue; }
                ((IXControl)ctrl).Init();
                FwdNodes.Add((IXControl)ctrl);
            }
        }

        public void Pan(int dx, int dy)
        {
            if (!Drag) { return; }
            var dxy = new Point(dx, dy);
            Offset = Offset.Add(dxy);
            foreach (var ctrl in FwdNodes)
            {
                ctrl.Pan(dx, dy);
            }
            UpdateDraw();
        }

        public void Zoom(float amount)
        {
            CurrScale = Math.Clamp(CurrScale + amount, 0.1f, 5f);
            foreach (var ctrl in FwdNodes)
            {
                ctrl.Zoom(CurrScale);
            }
            UpdateDraw();
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
            Zoom(e.Delta / 120 * SCALE_CONST);
            base.OnMouseWheel(e);
        }

        public void SetPosition(int x, int y)
        {
            Offset = new Point(x, y);
        }

        public void AddNode(string text = "")
        {
            var cSz = (int)(75 * CurrScale);
            var node = new XCNode
            {
                Size = new(cSz, cSz),
                Text = text,
                Parent = this,
                Location = new Point(0, 0),
            };
            node.Init();
            node.Zoom(CurrScale);
            if (Parent != null)
            {
                node.SetPosition(Parent.Width / 2, Parent.Height / 2);
            }
            Controls.Add(node);
            FwdNodes.Add(node);
        }

        public void SetSelected(IXControl selection)
        {
            if (ModifierKeys == Keys.Shift && Selected != null)
            {
                if (!selection.Contains(Selected) && !Selected.Contains(selection) && Selected != selection)
                {
                    Selected.FwdNodes.Add(selection);
                    Debug.WriteLine($"LINK: {Selected} -> {selection}");
                }
            }

            if (Selected != null && Selected != selection)
            {
                ((Control)Selected).ForeColor = Color.Black;
            }

            Selected = selection;
            ((Control)Selected).ForeColor = Color.Red;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(BMBuffer, 0, 0);
            base.OnPaint(e);
        }

        public bool Contains(IXControl control)
        {
            return FwdNodes.Contains(control);
        }

        public void UpdateDraw()
        {
            var pen = new Pen(Color.Red, 3f);
            var curve = .3f;
            GBuffer.Clear(Color.Transparent);
            foreach (XCNode pnt in FwdNodes.Cast<XCNode>())
            {
                var nodes = pnt.FwdNodes.Cast<XCNode>();
                var start = pnt.Location.Add(new Point(pnt.Width / 2, pnt.Height / 2));

                foreach (XCNode node in nodes)
                {
                    var end = node.Location.Add(new Point(node.Width / 2, node.Height / 2));
                    var dist = GeomHelper.Dist(start, end) * curve;
                    var angle = GeomHelper.Angle(start, end);
                    var lp1 = new Point((int)(start.X + dist), (int)(start.Y - dist));
                    var lp2 = new Point((int)(end.X - dist), (int)(end.Y + dist));
                    Debug.WriteLine($"{start}, {start}, {end}, {end} | {angle}::{dist}");
                    GBuffer.DrawBezier(pen, start, lp1, lp2, end);
                }
            }

            Refresh();
        }
    }
}
