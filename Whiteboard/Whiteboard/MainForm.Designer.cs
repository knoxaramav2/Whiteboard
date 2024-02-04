namespace Whiteboard
{
    partial class Whiteboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whiteboard));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            flowPanelContext = new ContextMenuStrip(components);
            flowPanelNewNode = new ToolStripMenuItem();
            AuxControls = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            HistorySlider = new TrackBar();
            EditorPanels = new TabControl();
            CharactersPane = new TabPage();
            CharacterPanel = new Panel();
            FlowPane = new TabPage();
            FlowPanel = new XCPanel();
            xcNode2 = new XCNode();
            xcNode1 = new XCNode();
            menuStrip1.SuspendLayout();
            flowPanelContext.SuspendLayout();
            AuxControls.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistorySlider).BeginInit();
            EditorPanels.SuspendLayout();
            CharactersPane.SuspendLayout();
            FlowPane.SuspendLayout();
            FlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(100, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
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
            AuxControls.Location = new Point(0, 330);
            AuxControls.Name = "AuxControls";
            AuxControls.SelectedIndex = 0;
            AuxControls.Size = new Size(800, 120);
            AuxControls.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 92);
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
            panel1.Size = new Size(786, 86);
            panel1.TabIndex = 0;
            // 
            // HistorySlider
            // 
            HistorySlider.Dock = DockStyle.Bottom;
            HistorySlider.Location = new Point(0, 41);
            HistorySlider.Maximum = 20;
            HistorySlider.Name = "HistorySlider";
            HistorySlider.Size = new Size(786, 45);
            HistorySlider.TabIndex = 0;
            HistorySlider.Scroll += HistorySlider_Scroll;
            // 
            // EditorPanels
            // 
            EditorPanels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditorPanels.Controls.Add(CharactersPane);
            EditorPanels.Controls.Add(FlowPane);
            EditorPanels.Location = new Point(0, 27);
            EditorPanels.Name = "EditorPanels";
            EditorPanels.SelectedIndex = 0;
            EditorPanels.Size = new Size(800, 304);
            EditorPanels.TabIndex = 2;
            // 
            // CharactersPane
            // 
            CharactersPane.BackColor = Color.Transparent;
            CharactersPane.Controls.Add(CharacterPanel);
            CharactersPane.Location = new Point(4, 24);
            CharactersPane.Name = "CharactersPane";
            CharactersPane.Padding = new Padding(3);
            CharactersPane.Size = new Size(792, 276);
            CharactersPane.TabIndex = 0;
            CharactersPane.Text = "Characters";
            // 
            // CharacterPanel
            // 
            CharacterPanel.BackColor = Color.RosyBrown;
            CharacterPanel.Dock = DockStyle.Fill;
            CharacterPanel.Location = new Point(3, 3);
            CharacterPanel.Name = "CharacterPanel";
            CharacterPanel.Size = new Size(786, 270);
            CharacterPanel.TabIndex = 0;
            // 
            // FlowPane
            // 
            FlowPane.BackColor = Color.Transparent;
            FlowPane.Controls.Add(FlowPanel);
            FlowPane.Location = new Point(4, 24);
            FlowPane.Name = "FlowPane";
            FlowPane.Padding = new Padding(3);
            FlowPane.Size = new Size(792, 276);
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
            FlowPanel.FwdNodes = (List<Whiteboard.IXControl>)resources.GetObject("FlowPanel.FwdNodes");
            FlowPanel.Location = new Point(3, 3);
            FlowPanel.Name = "FlowPanel";
            FlowPanel.Offset = new Point(0, 0);
            FlowPanel.Size = new Size(786, 270);
            FlowPanel.TabIndex = 0;
            // 
            // xcNode2
            // 
            xcNode2.BackColor = Color.Transparent;
            xcNode2.BaseDim = new Point(0, 0);
            xcNode2.Drag = false;
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
            xcNode1.BackColor = Color.Transparent;
            xcNode1.BaseDim = new Point(0, 0);
            xcNode1.Drag = false;
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
            // Whiteboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditorPanels);
            Controls.Add(AuxControls);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Whiteboard";
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
            CharactersPane.ResumeLayout(false);
            FlowPane.ResumeLayout(false);
            FlowPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip flowPanelContext;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl AuxControls;
        private TabPage tabPage1;
        private Panel panel1;
        private TrackBar HistorySlider;
        private TabControl EditorPanels;
        private TabPage CharactersPane;
        private TabPage FlowPane;
        private XCPanel FlowPanel;
        private XCNode xcNode1;
        private XCNode xcNode2;
        private Panel CharacterPanel;
        private ToolStripMenuItem flowPanelNewNode;
    }
}
