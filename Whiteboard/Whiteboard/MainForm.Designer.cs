using Whiteboard.Controls;

namespace Whiteboard
{
    partial class WhiteboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Button DeleteRowBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteboardForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewCtx = new ToolStripMenuItem();
            OpenCtx = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveCtx = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ExitCtx = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            flowPanelContext = new ContextMenuStrip(components);
            flowPanelNewNode = new ToolStripMenuItem();
            AuxControls = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            HistorySlider = new TrackBar();
            EditorPanels = new TabControl();
            CharactersSplitPane = new TabPage();
            CharacterPanel = new Panel();
            CharSplit = new SplitContainer();
            CharacterInfoSelect = new ComboBox();
            label2 = new Label();
            GenderSelect = new ComboBox();
            Notes = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            PortraitBtn = new Button();
            CharacterPortrait = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            NoteTableInsertBtn = new Button();
            FlowPane = new TabPage();
            FlowPanel = new XCPanel();
            xcNode2 = new XCNode();
            xcNode1 = new XCNode();
            ImageDialog = new OpenFileDialog();
            SaveAsCtx = new ToolStripMenuItem();
            DeleteRowBtn = new Button();
            menuStrip1.SuspendLayout();
            flowPanelContext.SuspendLayout();
            AuxControls.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistorySlider).BeginInit();
            EditorPanels.SuspendLayout();
            CharactersSplitPane.SuspendLayout();
            CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CharSplit).BeginInit();
            CharSplit.Panel1.SuspendLayout();
            CharSplit.Panel2.SuspendLayout();
            CharSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CharacterPortrait).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            FlowPane.SuspendLayout();
            FlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteRowBtn
            // 
            DeleteRowBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeleteRowBtn.BackColor = Color.LightGray;
            DeleteRowBtn.Font = new Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            DeleteRowBtn.ForeColor = Color.Red;
            DeleteRowBtn.ImageAlign = ContentAlignment.MiddleRight;
            DeleteRowBtn.Location = new Point(0, 20);
            DeleteRowBtn.Margin = new Padding(0);
            DeleteRowBtn.Name = "DeleteRowBtn";
            DeleteRowBtn.Size = new Size(60, 26);
            DeleteRowBtn.TabIndex = 6;
            DeleteRowBtn.Text = "X";
            DeleteRowBtn.TextAlign = ContentAlignment.TopCenter;
            DeleteRowBtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(880, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewCtx, OpenCtx, toolStripSeparator1, SaveCtx, SaveAsCtx, toolStripSeparator2, ExitCtx });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewCtx
            // 
            NewCtx.Name = "NewCtx";
            NewCtx.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            NewCtx.Size = new Size(180, 22);
            NewCtx.Text = "New";
            NewCtx.Click += NewToolStripMenuItem_Click;
            // 
            // OpenCtx
            // 
            OpenCtx.Name = "OpenCtx";
            OpenCtx.ShortcutKeys = Keys.Control | Keys.O;
            OpenCtx.Size = new Size(180, 22);
            OpenCtx.Text = "Open";
            OpenCtx.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // SaveCtx
            // 
            SaveCtx.Name = "SaveCtx";
            SaveCtx.ShortcutKeys = Keys.Control | Keys.S;
            SaveCtx.Size = new Size(180, 22);
            SaveCtx.Text = "Save";
            SaveCtx.Click += SaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // ExitCtx
            // 
            ExitCtx.Name = "ExitCtx";
            ExitCtx.Size = new Size(180, 22);
            ExitCtx.Text = "Exit";
            ExitCtx.Click += ExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // flowPanelContext
            // 
            flowPanelContext.Items.AddRange(new ToolStripItem[] { flowPanelNewNode });
            flowPanelContext.Name = "FlowPanelContext";
            flowPanelContext.Size = new Size(174, 26);
            // 
            // flowPanelNewNode
            // 
            flowPanelNewNode.Name = "flowPanelNewNode";
            flowPanelNewNode.ShortcutKeys = Keys.Control | Keys.N;
            flowPanelNewNode.Size = new Size(173, 22);
            flowPanelNewNode.Text = "New Node";
            flowPanelNewNode.Click += FlowPanelNewNode_Click;
            // 
            // AuxControls
            // 
            AuxControls.Controls.Add(tabPage1);
            AuxControls.Dock = DockStyle.Bottom;
            AuxControls.Location = new Point(0, 471);
            AuxControls.Name = "AuxControls";
            AuxControls.SelectedIndex = 0;
            AuxControls.Size = new Size(880, 120);
            AuxControls.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Timeline";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(HistorySlider);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 86);
            panel1.TabIndex = 0;
            // 
            // HistorySlider
            // 
            HistorySlider.Dock = DockStyle.Bottom;
            HistorySlider.Location = new Point(0, 41);
            HistorySlider.Maximum = 20;
            HistorySlider.Name = "HistorySlider";
            HistorySlider.Size = new Size(866, 45);
            HistorySlider.TabIndex = 0;
            HistorySlider.Scroll += HistorySlider_Scroll;
            // 
            // EditorPanels
            // 
            EditorPanels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditorPanels.Controls.Add(CharactersSplitPane);
            EditorPanels.Controls.Add(FlowPane);
            EditorPanels.Location = new Point(0, 27);
            EditorPanels.Name = "EditorPanels";
            EditorPanels.SelectedIndex = 0;
            EditorPanels.Size = new Size(880, 445);
            EditorPanels.TabIndex = 2;
            // 
            // CharactersSplitPane
            // 
            CharactersSplitPane.BackColor = Color.Transparent;
            CharactersSplitPane.Controls.Add(CharacterPanel);
            CharactersSplitPane.Location = new Point(4, 24);
            CharactersSplitPane.Name = "CharactersSplitPane";
            CharactersSplitPane.Padding = new Padding(3);
            CharactersSplitPane.Size = new Size(872, 417);
            CharactersSplitPane.TabIndex = 0;
            CharactersSplitPane.Text = "Characters";
            // 
            // CharacterPanel
            // 
            CharacterPanel.BackColor = Color.RosyBrown;
            CharacterPanel.Controls.Add(CharSplit);
            CharacterPanel.Dock = DockStyle.Fill;
            CharacterPanel.Location = new Point(3, 3);
            CharacterPanel.Name = "CharacterPanel";
            CharacterPanel.Size = new Size(866, 411);
            CharacterPanel.TabIndex = 0;
            // 
            // CharSplit
            // 
            CharSplit.BorderStyle = BorderStyle.Fixed3D;
            CharSplit.Dock = DockStyle.Fill;
            CharSplit.Location = new Point(0, 0);
            CharSplit.Margin = new Padding(1);
            CharSplit.Name = "CharSplit";
            // 
            // CharSplit.Panel1
            // 
            CharSplit.Panel1.BackColor = Color.Transparent;
            CharSplit.Panel1.Controls.Add(CharacterInfoSelect);
            CharSplit.Panel1.Controls.Add(label2);
            CharSplit.Panel1.Controls.Add(GenderSelect);
            CharSplit.Panel1.Controls.Add(Notes);
            CharSplit.Panel1.Controls.Add(textBox1);
            CharSplit.Panel1.Controls.Add(label1);
            CharSplit.Panel1.Controls.Add(PortraitBtn);
            CharSplit.Panel1.Controls.Add(CharacterPortrait);
            // 
            // CharSplit.Panel2
            // 
            CharSplit.Panel2.Controls.Add(tableLayoutPanel1);
            CharSplit.Size = new Size(866, 411);
            CharSplit.SplitterDistance = 323;
            CharSplit.TabIndex = 0;
            // 
            // CharacterInfoSelect
            // 
            CharacterInfoSelect.FormattingEnabled = true;
            CharacterInfoSelect.Location = new Point(3, 164);
            CharacterInfoSelect.Name = "CharacterInfoSelect";
            CharacterInfoSelect.Size = new Size(158, 23);
            CharacterInfoSelect.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(165, 45);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GenderSelect
            // 
            GenderSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenderSelect.DisplayMember = "(none)";
            GenderSelect.FormattingEnabled = true;
            GenderSelect.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GenderSelect.Location = new Point(165, 63);
            GenderSelect.Name = "GenderSelect";
            GenderSelect.Size = new Size(149, 23);
            GenderSelect.TabIndex = 4;
            // 
            // Notes
            // 
            Notes.AcceptsReturn = true;
            Notes.AcceptsTab = true;
            Notes.Dock = DockStyle.Bottom;
            Notes.Location = new Point(0, 309);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.PlaceholderText = "Notes";
            Notes.ScrollBars = ScrollBars.Both;
            Notes.Size = new Size(319, 98);
            Notes.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(165, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(166, 1);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // PortraitBtn
            // 
            PortraitBtn.BackColor = Color.White;
            PortraitBtn.Location = new Point(134, 137);
            PortraitBtn.Name = "PortraitBtn";
            PortraitBtn.Size = new Size(27, 24);
            PortraitBtn.TabIndex = 1;
            PortraitBtn.Text = "...";
            PortraitBtn.TextAlign = ContentAlignment.TopCenter;
            PortraitBtn.UseVisualStyleBackColor = false;
            PortraitBtn.Click += ImageDialog_FileOk;
            // 
            // CharacterPortrait
            // 
            CharacterPortrait.BackgroundImage = (Image)resources.GetObject("CharacterPortrait.BackgroundImage");
            CharacterPortrait.BorderStyle = BorderStyle.FixedSingle;
            CharacterPortrait.Location = new Point(1, 1);
            CharacterPortrait.Name = "CharacterPortrait";
            CharacterPortrait.Size = new Size(160, 160);
            CharacterPortrait.TabIndex = 0;
            CharacterPortrait.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 1);
            tableLayoutPanel1.Controls.Add(NoteTableInsertBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(DeleteRowBtn, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(529, 168);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.OutlineButton;
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Control";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(63, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 15);
            label4.TabIndex = 2;
            label4.Text = "Field";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(311, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 15);
            label5.TabIndex = 4;
            label5.Text = "Info";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.AllowDrop = true;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(63, 23);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Field Name";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(311, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Note";
            textBox3.Size = new Size(215, 112);
            textBox3.TabIndex = 5;
            // 
            // NoteTableInsertBtn
            // 
            NoteTableInsertBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NoteTableInsertBtn.BackColor = Color.LightGray;
            NoteTableInsertBtn.BackgroundImageLayout = ImageLayout.Zoom;
            NoteTableInsertBtn.FlatAppearance.BorderSize = 0;
            NoteTableInsertBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoteTableInsertBtn.ForeColor = Color.Green;
            NoteTableInsertBtn.Location = new Point(499, 138);
            NoteTableInsertBtn.Margin = new Padding(0);
            NoteTableInsertBtn.Name = "NoteTableInsertBtn";
            NoteTableInsertBtn.Size = new Size(30, 30);
            NoteTableInsertBtn.TabIndex = 3;
            NoteTableInsertBtn.Text = "+";
            NoteTableInsertBtn.TextAlign = ContentAlignment.TopCenter;
            NoteTableInsertBtn.UseVisualStyleBackColor = false;
            // 
            // FlowPane
            // 
            FlowPane.BackColor = Color.Transparent;
            FlowPane.Controls.Add(FlowPanel);
            FlowPane.Location = new Point(4, 24);
            FlowPane.Name = "FlowPane";
            FlowPane.Padding = new Padding(3);
            FlowPane.Size = new Size(872, 417);
            FlowPane.TabIndex = 1;
            FlowPane.Text = "Flow";
            // 
            // FlowPanel
            // 
            FlowPanel.BackColor = Color.SteelBlue;
            FlowPanel.BorderStyle = BorderStyle.FixedSingle;
            FlowPanel.ContextMenuStrip = flowPanelContext;
            FlowPanel.Controls.Add(xcNode2);
            FlowPanel.Controls.Add(xcNode1);
            FlowPanel.Dock = DockStyle.Fill;
            FlowPanel.FwdNodes = null;
            FlowPanel.Location = new Point(3, 3);
            FlowPanel.Name = "FlowPanel";
            FlowPanel.Offset = new Point(0, 0);
            FlowPanel.Size = new Size(866, 411);
            FlowPanel.TabIndex = 0;
            // 
            // xcNode2
            // 
            xcNode2.BackColor = Color.Silver;
            xcNode2.BackgroundImageLayout = ImageLayout.None;
            xcNode2.BaseDim = new Point(0, 0);
            xcNode2.Drag = false;
            xcNode2.FlatAppearance.BorderSize = 0;
            xcNode2.FlatStyle = FlatStyle.Flat;
            xcNode2.LastMousePosition = new Point(0, 0);
            xcNode2.Location = new Point(193, 149);
            xcNode2.Name = "xcNode2";
            xcNode2.Offset = new Point(0, 0);
            xcNode2.Size = new Size(75, 75);
            xcNode2.TabIndex = 1;
            xcNode2.Text = "xcNode2";
            xcNode2.UseVisualStyleBackColor = false;
            // 
            // xcNode1
            // 
            xcNode1.BackColor = Color.Silver;
            xcNode1.BackgroundImageLayout = ImageLayout.None;
            xcNode1.BaseDim = new Point(0, 0);
            xcNode1.Drag = false;
            xcNode1.FlatAppearance.BorderSize = 0;
            xcNode1.FlatStyle = FlatStyle.Flat;
            xcNode1.ForeColor = SystemColors.ControlText;
            xcNode1.LastMousePosition = new Point(0, 0);
            xcNode1.Location = new Point(340, 3);
            xcNode1.Name = "xcNode1";
            xcNode1.Offset = new Point(0, 0);
            xcNode1.Size = new Size(75, 75);
            xcNode1.TabIndex = 0;
            xcNode1.Text = "xcNode1";
            xcNode1.UseVisualStyleBackColor = false;
            // 
            // SaveAsCtx
            // 
            SaveAsCtx.Name = "SaveAsCtx";
            SaveAsCtx.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SaveAsCtx.Size = new Size(186, 22);
            SaveAsCtx.Text = "Save As";
            SaveAsCtx.Click += SaveAsCtx_Click;
            // 
            // WhiteboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 591);
            Controls.Add(EditorPanels);
            Controls.Add(AuxControls);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(890, 630);
            Name = "WhiteboardForm";
            Text = "Whiteboard";
            Load += Whiteboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowPanelContext.ResumeLayout(false);
            AuxControls.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistorySlider).EndInit();
            EditorPanels.ResumeLayout(false);
            CharactersSplitPane.ResumeLayout(false);
            CharacterPanel.ResumeLayout(false);
            CharSplit.Panel1.ResumeLayout(false);
            CharSplit.Panel1.PerformLayout();
            CharSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CharSplit).EndInit();
            CharSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CharacterPortrait).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            FlowPane.ResumeLayout(false);
            FlowPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip flowPanelContext;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewCtx;
        private ToolStripMenuItem OpenCtx;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SaveCtx;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitCtx;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl AuxControls;
        private TabPage tabPage1;
        private Panel panel1;
        private TrackBar HistorySlider;
        private TabControl EditorPanels;
        private TabPage CharactersSplitPane;
        private TabPage FlowPane;
        private XCPanel FlowPanel;
        private XCNode xcNode1;
        private XCNode xcNode2;
        private Panel CharacterPanel;
        private ToolStripMenuItem flowPanelNewNode;
        private SplitContainer CharSplit;
        private PictureBox CharacterPortrait;
        private OpenFileDialog ImageDialog;
        private TextBox textBox1;
        private Label label1;
        private Button PortraitBtn;
        private TextBox Notes;
        private Label label2;
        private ComboBox GenderSelect;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button NoteTableInsertBtn;
        private Label label5;
        private TextBox textBox3;
        private ComboBox CharacterInfoSelect;
        private ToolStripMenuItem SaveAsCtx;
    }
}
