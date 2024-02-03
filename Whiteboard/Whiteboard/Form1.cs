using System.ComponentModel;
using System.Diagnostics;

namespace Whiteboard
{
    public partial class Whiteboard : Form
    {
        public Whiteboard()
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

        private void FlowPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"R:{e.Delta} | BTN:{e.Button}");
        }
    }
}
