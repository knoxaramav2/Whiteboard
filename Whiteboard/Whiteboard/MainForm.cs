using System.Diagnostics;
using Whiteboard.Controls;
using Whiteboard.State;
using Whiteboard.Util;

namespace Whiteboard
{
    public partial class WhiteboardForm : Form
    {
        GlobalState GlobalState;
        StoryState? StoryState;

        public WhiteboardForm()
        {
            InitializeComponent();
            FlowPanel.Init();
            SetUIEnabled(false);

            GlobalState = GlobalState.Load();
            if (!string.IsNullOrEmpty(GlobalState.LastSavePath))
            {
                LoadStory(GlobalState.LastSavePath);
            }
        }

        private void LoadStory(string path)
        {
            var save = StoryState.Load(path);
            if (save == null)
            {
                //TODO ERROR
                return;
            }

            SetStory(save);
        }

        private void SetUIEnabled(bool lockControls)
        {
            AuxControls.Enabled = lockControls;
            EditorPanels.Enabled = lockControls;
            SaveAsCtx.Enabled = lockControls;
            SaveCtx.Enabled = lockControls;
        }

        private void SetStory(StoryState storyState)
        {
            StoryState = storyState;
            GlobalState.SetCurrentStory(StoryState);
            Text = StoryState.ProfileName;
            SetUIEnabled(true);
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
            openFileDialog1.Title = "New Story";
            openFileDialog1.Filter = "Story File | *.stry";
            openFileDialog1.InitialDirectory = FileIO.DataPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                var fileName = Path.GetFileNameWithoutExtension(filePath);
                var newStory = new StoryState(fileName, filePath);
                if (newStory == null)
                {
                    //Error
                    return;
                }

                SetStory(newStory);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Story";
            openFileDialog1.Filter = "Story File | *.stry";
            openFileDialog1.InitialDirectory = FileIO.DataPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadStory(openFileDialog1.FileName);
            }
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
            var res = Prompts.InputDialog("Create new flow node", "Create");
            if (!string.IsNullOrEmpty(res)) { FlowPanel.AddNode(res); }
        }

        private void FlowPanelDeleteNode_Click(object sender, EventArgs e)
        {
            if (Prompts.ConfirmDialog("This operation cannot be undone.", "Delete") == DialogResult.OK)
            {
                FlowPanel.DeleteNode();
            }
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
