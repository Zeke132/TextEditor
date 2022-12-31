namespace TextEditor
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources in use.
        /// </summary>
        /// <param name="disposing">True if the managed resource should be released; Otherwise, it is false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tolbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tolbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tolbtnSaveas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tolbtnisolite = new System.Windows.Forms.ToolStripButton();
            this.tolbtnUnderLine = new System.Windows.Forms.ToolStripButton();
            this.cbbFontsize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tolbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tolbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tolbtnPast = new System.Windows.Forms.ToolStripButton();
            this.rich = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::TextEditor.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::TextEditor.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.tolbtnOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::TextEditor.Properties.Resources.document_save_as;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.tolbtnSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_save_173091;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.tolbtnSaveas_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::TextEditor.Properties.Resources.gnome_logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pastToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_clipboard_cut_42190;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.tolbtnCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_icon_ios7_copy_outline_2117321;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.tolbtnCopy_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_paste_3671826;
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pastToolStripMenuItem.Text = "Past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.tolbtnPast_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolbtnNew,
            this.tolbtnOpen,
            this.tolbtnSave,
            this.tolbtnSaveas,
            this.toolStripSeparator1,
            this.tolbtnBold,
            this.tolbtnisolite,
            this.tolbtnUnderLine,
            this.cbbFontsize,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tolbtnNew
            // 
            this.tolbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnNew.Image = global::TextEditor.Properties.Resources._new;
            this.tolbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnNew.Name = "tolbtnNew";
            this.tolbtnNew.Size = new System.Drawing.Size(29, 25);
            this.tolbtnNew.Text = "New File";
            this.tolbtnNew.Click += new System.EventHandler(this.tolbtnNew_Click);
            // 
            // tolbtnOpen
            // 
            this.tolbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnOpen.Image = global::TextEditor.Properties.Resources.open;
            this.tolbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnOpen.Name = "tolbtnOpen";
            this.tolbtnOpen.Size = new System.Drawing.Size(29, 25);
            this.tolbtnOpen.Text = "Open File";
            this.tolbtnOpen.Click += new System.EventHandler(this.tolbtnOpen_Click);
            // 
            // tolbtnSave
            // 
            this.tolbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnSave.Image = global::TextEditor.Properties.Resources.document_save_as;
            this.tolbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnSave.Name = "tolbtnSave";
            this.tolbtnSave.Size = new System.Drawing.Size(29, 25);
            this.tolbtnSave.Text = "Save";
            this.tolbtnSave.Click += new System.EventHandler(this.tolbtnSave_Click);
            // 
            // tolbtnSaveas
            // 
            this.tolbtnSaveas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnSaveas.Image = global::TextEditor.Properties.Resources.if_save_173091;
            this.tolbtnSaveas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnSaveas.Name = "tolbtnSaveas";
            this.tolbtnSaveas.Size = new System.Drawing.Size(29, 25);
            this.tolbtnSaveas.Text = "Save As...";
            this.tolbtnSaveas.Click += new System.EventHandler(this.tolbtnSaveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tolbtnBold
            // 
            this.tolbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnBold.Image = global::TextEditor.Properties.Resources.font_bold;
            this.tolbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnBold.Name = "tolbtnBold";
            this.tolbtnBold.Size = new System.Drawing.Size(29, 25);
            this.tolbtnBold.Text = "Bold Font";
            this.tolbtnBold.Click += new System.EventHandler(this.tolbtnBold_Click);
            // 
            // tolbtnisolite
            // 
            this.tolbtnisolite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnisolite.Image = global::TextEditor.Properties.Resources.font_italic;
            this.tolbtnisolite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnisolite.Name = "tolbtnisolite";
            this.tolbtnisolite.Size = new System.Drawing.Size(29, 25);
            this.tolbtnisolite.Text = "Italics Font";
            this.tolbtnisolite.Click += new System.EventHandler(this.tolbtnisolite_Click);
            // 
            // tolbtnUnderLine
            // 
            this.tolbtnUnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnUnderLine.Image = global::TextEditor.Properties.Resources._105_underline;
            this.tolbtnUnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnUnderLine.Name = "tolbtnUnderLine";
            this.tolbtnUnderLine.Size = new System.Drawing.Size(29, 25);
            this.tolbtnUnderLine.Text = "UnderLine Font";
            this.tolbtnUnderLine.Click += new System.EventHandler(this.tolbtnUnderLine_Click);
            // 
            // cbbFontsize
            // 
            this.cbbFontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFontsize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbbFontsize.Name = "cbbFontsize";
            this.cbbFontsize.Size = new System.Drawing.Size(160, 28);
            this.cbbFontsize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.cbbFontsize.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 25);
            this.toolStripLabel1.Text = "Hello World";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolbtnCut,
            this.tolbtnCopy,
            this.tolbtnPast});
            this.toolStrip2.Location = new System.Drawing.Point(0, 61);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(30, 576);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tolbtnCut
            // 
            this.tolbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnCut.Image = global::TextEditor.Properties.Resources.if_clipboard_cut_42190;
            this.tolbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnCut.Name = "tolbtnCut";
            this.tolbtnCut.Size = new System.Drawing.Size(27, 24);
            this.tolbtnCut.Text = "toolStripButton6";
            this.tolbtnCut.Click += new System.EventHandler(this.tolbtnCut_Click);
            // 
            // tolbtnCopy
            // 
            this.tolbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnCopy.Image = global::TextEditor.Properties.Resources.if_icon_ios7_copy_outline_211732;
            this.tolbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnCopy.Name = "tolbtnCopy";
            this.tolbtnCopy.Size = new System.Drawing.Size(27, 24);
            this.tolbtnCopy.Text = "toolStripButton7";
            this.tolbtnCopy.Click += new System.EventHandler(this.tolbtnCopy_Click);
            // 
            // tolbtnPast
            // 
            this.tolbtnPast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolbtnPast.Image = global::TextEditor.Properties.Resources.if_paste_3671826;
            this.tolbtnPast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnPast.Name = "tolbtnPast";
            this.tolbtnPast.Size = new System.Drawing.Size(27, 24);
            this.tolbtnPast.Text = "toolStripButton8";
            this.tolbtnPast.Click += new System.EventHandler(this.tolbtnPast_Click);
            // 
            // rich
            // 
            this.rich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich.Location = new System.Drawing.Point(30, 61);
            this.rich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rich.Name = "rich";
            this.rich.Size = new System.Drawing.Size(1037, 576);
            this.rich.TabIndex = 3;
            this.rich.Text = "";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 637);
            this.Controls.Add(this.rich);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolbtnNew;
        private System.Windows.Forms.ToolStripButton tolbtnOpen;
        private System.Windows.Forms.ToolStripButton tolbtnSaveas;
        private System.Windows.Forms.ToolStripButton tolbtnSave;
        private System.Windows.Forms.ToolStripButton tolbtnBold;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tolbtnCut;
        private System.Windows.Forms.ToolStripButton tolbtnCopy;
        private System.Windows.Forms.ToolStripButton tolbtnPast;
        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tolbtnisolite;
        private System.Windows.Forms.ToolStripButton tolbtnUnderLine;
        private System.Windows.Forms.ToolStripComboBox cbbFontsize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

