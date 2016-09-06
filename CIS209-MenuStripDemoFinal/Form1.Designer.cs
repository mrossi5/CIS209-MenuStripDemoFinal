namespace CIS209_MenuStripDemoFinal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sortEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ascSortEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.decSortEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitFileMenu,
            this.textFileMenu,
            this.picturesToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 29);
            this.fileMenu.Text = "File";
            // 
            // ExitFileMenu
            // 
            this.ExitFileMenu.Name = "ExitFileMenu";
            this.ExitFileMenu.Size = new System.Drawing.Size(211, 30);
            this.ExitFileMenu.Text = "Exit";
            // 
            // textFileMenu
            // 
            this.textFileMenu.Name = "textFileMenu";
            this.textFileMenu.Size = new System.Drawing.Size(211, 30);
            this.textFileMenu.Text = "Text Editor";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyEditMenu,
            this.cutEditMenu,
            this.pasteEditMenu,
            this.findEditMenu,
            this.sortEditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(54, 29);
            this.editMenu.Text = "Edit";
            // 
            // copyEditMenu
            // 
            this.copyEditMenu.Name = "copyEditMenu";
            this.copyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyEditMenu.Size = new System.Drawing.Size(211, 30);
            this.copyEditMenu.Text = "Copy";
            // 
            // cutEditMenu
            // 
            this.cutEditMenu.Name = "cutEditMenu";
            this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenu.Size = new System.Drawing.Size(211, 30);
            this.cutEditMenu.Text = "Cut";
            // 
            // pasteEditMenu
            // 
            this.pasteEditMenu.Name = "pasteEditMenu";
            this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenu.Size = new System.Drawing.Size(211, 30);
            this.pasteEditMenu.Text = "Paste";
            // 
            // findEditMenu
            // 
            this.findEditMenu.Name = "findEditMenu";
            this.findEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findEditMenu.Size = new System.Drawing.Size(211, 30);
            this.findEditMenu.Text = "Find";
            // 
            // sortEditMenu
            // 
            this.sortEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascSortEditMenu,
            this.decSortEditMenu});
            this.sortEditMenu.Name = "sortEditMenu";
            this.sortEditMenu.Size = new System.Drawing.Size(211, 30);
            this.sortEditMenu.Text = "Sort";
            // 
            // ascSortEditMenu
            // 
            this.ascSortEditMenu.Name = "ascSortEditMenu";
            this.ascSortEditMenu.Size = new System.Drawing.Size(182, 30);
            this.ascSortEditMenu.Text = "Ascending";
            // 
            // decSortEditMenu
            // 
            this.decSortEditMenu.Name = "decSortEditMenu";
            this.decSortEditMenu.Size = new System.Drawing.Size(182, 30);
            this.decSortEditMenu.Text = "Decending";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(61, 29);
            this.helpMenu.Text = "Help";
            // 
            // picturesToolStripMenuItem
            // 
            this.picturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pic1});
            this.picturesToolStripMenuItem.Name = "picturesToolStripMenuItem";
            this.picturesToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.picturesToolStripMenuItem.Text = "Pictures";
            // 
            // pic1
            // 
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(211, 30);
            this.pic1.Text = "pic1";
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 540);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem textFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenu;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem findEditMenu;
        private System.Windows.Forms.ToolStripMenuItem sortEditMenu;
        private System.Windows.Forms.ToolStripMenuItem ascSortEditMenu;
        private System.Windows.Forms.ToolStripMenuItem decSortEditMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem picturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pic1;
    }
}

