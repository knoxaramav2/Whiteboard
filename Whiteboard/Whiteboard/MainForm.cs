using System.Diagnostics;
using Whiteboard.Controls;
using Whiteboard.Util;

namespace Whiteboard
{
    public partial class WhiteboardForm : Form
    {
        public WhiteboardForm()
        {
            InitializeComponent();
            FlowPanel.Init();
        }

        private void Whiteboard_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HistorySlider_Scroll(object sender, EventArgs e)
        {
            Debug.WriteLine($"{HistorySlider.Minimum}>{HistorySlider.Value}>{HistorySlider.Maximum}");
        }

        private void ZoomSlider_Scroll(object sender, EventArgs e)
        {
            //FlowPane.Coll
        }

        private void FlowPanelNewNode_Click(object sender, EventArgs e)
        {
            var res = Prompts.NewNodeDialog("Create new flow node", "Create");
            if (!string.IsNullOrEmpty(res)) { FlowPanel.AddNode(res); }
        }

        private void ImageDialog_FileOk(object sender, EventArgs e)
        {
            ImageDialog.Filter = "Image File (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            ImageDialog.Title = "Portrait Image";
            if (ImageDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = ImageDialog.FileName;
                var img = Image.FromFile(fileName);
                var sz = CharacterPortrait.Size;
                CharacterPortrait.BackgroundImage = ImageHelper.Resize(img, sz.Width, sz.Height);
            }
        }

        private void SaveAsCtx_Click(object sender, EventArgs e)
        {

        }
    }
}
