namespace CIS376_TermProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rootLb = new System.Windows.Forms.ListBox();
            this.HelpCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.ScaleCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MajorRb = new System.Windows.Forms.RadioButton();
            this.MinorRb = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleLbl = new System.Windows.Forms.Label();
            this.RootTitle = new System.Windows.Forms.Label();
            this.StatusSb = new System.Windows.Forms.StatusStrip();
            this.StatusTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ScaleTypeGB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HelpCMS.SuspendLayout();
            this.ScaleCMS.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.StatusSb.SuspendLayout();
            this.ScaleTypeGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLb
            // 
            this.rootLb.ContextMenuStrip = this.HelpCMS;
            this.rootLb.FormattingEnabled = true;
            this.rootLb.Location = new System.Drawing.Point(6, 106);
            this.rootLb.Name = "rootLb";
            this.rootLb.Size = new System.Drawing.Size(102, 186);
            this.rootLb.TabIndex = 0;
            this.rootLb.SelectedIndexChanged += new System.EventHandler(this.ScaleRoot_Changed);
            // 
            // HelpCMS
            // 
            this.HelpCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2});
            this.HelpCMS.Name = "HelpCMS";
            this.HelpCMS.Size = new System.Drawing.Size(100, 26);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.ViewHelpForm);
            // 
            // outputTxt
            // 
            this.outputTxt.AccessibleName = "Scale";
            this.outputTxt.BackColor = System.Drawing.SystemColors.Window;
            this.outputTxt.ContextMenuStrip = this.ScaleCMS;
            this.outputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTxt.Location = new System.Drawing.Point(6, 39);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(153, 252);
            this.outputTxt.TabIndex = 3;
            // 
            // ScaleCMS
            // 
            this.ScaleCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator3,
            this.helpToolStripMenuItem1});
            this.ScaleCMS.Name = "ScaleCMS";
            this.ScaleCMS.Size = new System.Drawing.Size(168, 54);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportToolStripMenuItem.Text = "Export to Text File";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.ViewHelpForm);
            // 
            // MajorRb
            // 
            this.MajorRb.AutoSize = true;
            this.MajorRb.ContextMenuStrip = this.HelpCMS;
            this.MajorRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorRb.Location = new System.Drawing.Point(6, 19);
            this.MajorRb.Name = "MajorRb";
            this.MajorRb.Size = new System.Drawing.Size(71, 24);
            this.MajorRb.TabIndex = 4;
            this.MajorRb.Text = "Major";
            this.MajorRb.UseVisualStyleBackColor = true;
            this.MajorRb.Click += new System.EventHandler(this.ScaleType_CheckedChanged);
            // 
            // MinorRb
            // 
            this.MinorRb.AutoSize = true;
            this.MinorRb.ContextMenuStrip = this.HelpCMS;
            this.MinorRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinorRb.Location = new System.Drawing.Point(6, 49);
            this.MinorRb.Name = "MinorRb";
            this.MinorRb.Size = new System.Drawing.Size(71, 24);
            this.MinorRb.TabIndex = 5;
            this.MinorRb.Text = "Minor";
            this.MinorRb.UseVisualStyleBackColor = true;
            this.MinorRb.Click += new System.EventHandler(this.ScaleType_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.printToolStripMenuItem.Text = "Export to Text File";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.ViewTutorialForm);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpForm);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ScaleLbl
            // 
            this.ScaleLbl.AutoSize = true;
            this.ScaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleLbl.Location = new System.Drawing.Point(6, 16);
            this.ScaleLbl.Name = "ScaleLbl";
            this.ScaleLbl.Size = new System.Drawing.Size(78, 20);
            this.ScaleLbl.TabIndex = 8;
            this.ScaleLbl.Text = "ScaleLbl";
            // 
            // RootTitle
            // 
            this.RootTitle.AutoSize = true;
            this.RootTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootTitle.Location = new System.Drawing.Point(6, 90);
            this.RootTitle.Name = "RootTitle";
            this.RootTitle.Size = new System.Drawing.Size(69, 13);
            this.RootTitle.TabIndex = 10;
            this.RootTitle.Text = "Root Note:";
            // 
            // StatusSb
            // 
            this.StatusSb.ContextMenuStrip = this.HelpCMS;
            this.StatusSb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTxt});
            this.StatusSb.Location = new System.Drawing.Point(0, 337);
            this.StatusSb.Name = "StatusSb";
            this.StatusSb.Size = new System.Drawing.Size(309, 22);
            this.StatusSb.TabIndex = 11;
            this.StatusSb.Text = "statusStrip1";
            // 
            // StatusTxt
            // 
            this.StatusTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(55, 17);
            this.StatusTxt.Text = "StatusTxt";
            // 
            // ScaleTypeGB
            // 
            this.ScaleTypeGB.Controls.Add(this.MajorRb);
            this.ScaleTypeGB.Controls.Add(this.RootTitle);
            this.ScaleTypeGB.Controls.Add(this.MinorRb);
            this.ScaleTypeGB.Controls.Add(this.rootLb);
            this.ScaleTypeGB.Location = new System.Drawing.Point(12, 27);
            this.ScaleTypeGB.Name = "ScaleTypeGB";
            this.ScaleTypeGB.Size = new System.Drawing.Size(114, 302);
            this.ScaleTypeGB.TabIndex = 13;
            this.ScaleTypeGB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputTxt);
            this.groupBox1.Controls.Add(this.ScaleLbl);
            this.groupBox1.Location = new System.Drawing.Point(132, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 302);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Lookup a scale based on the root note and the scale type.";
            this.AccessibleName = "Harry Potter and the Secret of the Chords";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(309, 359);
            this.ContextMenuStrip = this.HelpCMS;
            this.Controls.Add(this.StatusSb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ScaleTypeGB);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Harry Potter and the Secret of the Chords";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpCMS.ResumeLayout(false);
            this.ScaleCMS.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusSb.ResumeLayout(false);
            this.StatusSb.PerformLayout();
            this.ScaleTypeGB.ResumeLayout(false);
            this.ScaleTypeGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rootLb;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.RadioButton MajorRb;
        private System.Windows.Forms.RadioButton MinorRb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ScaleLbl;
        private System.Windows.Forms.Label RootTitle;
        private System.Windows.Forms.StatusStrip StatusSb;
        private System.Windows.Forms.ToolStripStatusLabel StatusTxt;
        private System.Windows.Forms.ContextMenuStrip ScaleCMS;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.GroupBox ScaleTypeGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip HelpCMS;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
    }
}

