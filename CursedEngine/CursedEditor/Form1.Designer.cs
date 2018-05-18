namespace CursedEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textEditor = new System.Windows.Forms.SplitContainer();
            this.roomText = new System.Windows.Forms.RichTextBox();
            this.actionGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.addActionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newLevelButton = new System.Windows.Forms.ToolStripButton();
            this.newRoomButton = new System.Windows.Forms.ToolStripButton();
            this.newDisplayButton = new System.Windows.Forms.ToolStripButton();
            this.gameMap = new System.Windows.Forms.TreeView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditor)).BeginInit();
            this.textEditor.Panel1.SuspendLayout();
            this.textEditor.Panel2.SuspendLayout();
            this.textEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionGridView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textEditor);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 606);
            this.splitContainer1.SplitterDistance = 808;
            this.splitContainer1.TabIndex = 1;
            // 
            // textEditor
            // 
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Location = new System.Drawing.Point(0, 25);
            this.textEditor.Name = "textEditor";
            this.textEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // textEditor.Panel1
            // 
            this.textEditor.Panel1.Controls.Add(this.roomText);
            // 
            // textEditor.Panel2
            // 
            this.textEditor.Panel2.Controls.Add(this.actionGridView);
            this.textEditor.Panel2.Controls.Add(this.toolStrip3);
            this.textEditor.Size = new System.Drawing.Size(808, 581);
            this.textEditor.SplitterDistance = 271;
            this.textEditor.TabIndex = 3;
            // 
            // roomText
            // 
            this.roomText.Location = new System.Drawing.Point(3, 3);
            this.roomText.Name = "roomText";
            this.roomText.Size = new System.Drawing.Size(802, 265);
            this.roomText.TabIndex = 3;
            this.roomText.Text = "";
            // 
            // actionGridView
            // 
            this.actionGridView.AllowUserToAddRows = false;
            this.actionGridView.AllowUserToResizeRows = false;
            this.actionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Keys,
            this.Code});
            this.actionGridView.Location = new System.Drawing.Point(3, 29);
            this.actionGridView.Name = "actionGridView";
            this.actionGridView.Size = new System.Drawing.Size(802, 274);
            this.actionGridView.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addActionButton});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(808, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // addActionButton
            // 
            this.addActionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addActionButton.Image = ((System.Drawing.Image)(resources.GetObject("addActionButton.Image")));
            this.addActionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addActionButton.Name = "addActionButton";
            this.addActionButton.Size = new System.Drawing.Size(23, 22);
            this.addActionButton.Text = "toolStripButton2";
            this.addActionButton.ToolTipText = "Add Action";
            this.addActionButton.Click += new System.EventHandler(this.addActionButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Run";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(271, 606);
            this.splitContainer2.SplitterDistance = 128;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(4, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer4.Panel1.Controls.Add(this.gameMap);
            this.splitContainer4.Size = new System.Drawing.Size(121, 600);
            this.splitContainer4.SplitterDistance = 322;
            this.splitContainer4.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelButton,
            this.newRoomButton,
            this.newDisplayButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(121, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newLevelButton
            // 
            this.newLevelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newLevelButton.Image = ((System.Drawing.Image)(resources.GetObject("newLevelButton.Image")));
            this.newLevelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newLevelButton.Name = "newLevelButton";
            this.newLevelButton.Size = new System.Drawing.Size(23, 22);
            this.newLevelButton.Text = "NewLevelButton";
            this.newLevelButton.ToolTipText = "Create new level";
            this.newLevelButton.Click += new System.EventHandler(this.newLevelButton_Click);
            // 
            // newRoomButton
            // 
            this.newRoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newRoomButton.Image = ((System.Drawing.Image)(resources.GetObject("newRoomButton.Image")));
            this.newRoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newRoomButton.Name = "newRoomButton";
            this.newRoomButton.Size = new System.Drawing.Size(23, 22);
            this.newRoomButton.Text = "Create New Room";
            this.newRoomButton.ToolTipText = "Create new room";
            this.newRoomButton.Click += new System.EventHandler(this.newRoomButton_Click);
            // 
            // newDisplayButton
            // 
            this.newDisplayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDisplayButton.Image = ((System.Drawing.Image)(resources.GetObject("newDisplayButton.Image")));
            this.newDisplayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDisplayButton.Name = "newDisplayButton";
            this.newDisplayButton.Size = new System.Drawing.Size(23, 22);
            this.newDisplayButton.Text = "toolStripButton3";
            // 
            // gameMap
            // 
            this.gameMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameMap.Location = new System.Drawing.Point(3, 28);
            this.gameMap.Name = "gameMap";
            this.gameMap.Size = new System.Drawing.Size(118, 291);
            this.gameMap.TabIndex = 0;
            this.gameMap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.gameMap_AfterSelect);
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // Keys
            // 
            this.Keys.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Keys.HeaderText = "Keys";
            this.Keys.Name = "Keys";
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 630);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.textEditor.Panel1.ResumeLayout(false);
            this.textEditor.Panel2.ResumeLayout(false);
            this.textEditor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditor)).EndInit();
            this.textEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionGridView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newLevelButton;
        private System.Windows.Forms.ToolStripButton newRoomButton;
        private System.Windows.Forms.ToolStripButton newDisplayButton;
        private System.Windows.Forms.SplitContainer textEditor;
        private System.Windows.Forms.RichTextBox roomText;
        internal System.Windows.Forms.TreeView gameMap;
        private System.Windows.Forms.DataGridView actionGridView;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton addActionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}

