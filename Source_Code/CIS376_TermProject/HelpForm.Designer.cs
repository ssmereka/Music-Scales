namespace CIS376_TermProject
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.HelpIndexLb = new System.Windows.Forms.ListBox();
            this.HelpTb = new System.Windows.Forms.TextBox();
            this.IndexTitleLb = new System.Windows.Forms.Label();
            this.TextTitleLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpIndexLb
            // 
            this.HelpIndexLb.FormattingEnabled = true;
            this.HelpIndexLb.Location = new System.Drawing.Point(12, 38);
            this.HelpIndexLb.Name = "HelpIndexLb";
            this.HelpIndexLb.Size = new System.Drawing.Size(120, 264);
            this.HelpIndexLb.TabIndex = 0;
            this.HelpIndexLb.SelectedIndexChanged += new System.EventHandler(this.HelpIndexLb_SelectedIndexChanged);
            // 
            // HelpTb
            // 
            this.HelpTb.BackColor = System.Drawing.SystemColors.Window;
            this.HelpTb.Location = new System.Drawing.Point(138, 38);
            this.HelpTb.Multiline = true;
            this.HelpTb.Name = "HelpTb";
            this.HelpTb.ReadOnly = true;
            this.HelpTb.Size = new System.Drawing.Size(287, 263);
            this.HelpTb.TabIndex = 1;
            this.HelpTb.TextChanged += new System.EventHandler(this.HelpTb_TextChanged);
            // 
            // IndexTitleLb
            // 
            this.IndexTitleLb.AutoSize = true;
            this.IndexTitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexTitleLb.Location = new System.Drawing.Point(12, 15);
            this.IndexTitleLb.Name = "IndexTitleLb";
            this.IndexTitleLb.Size = new System.Drawing.Size(103, 20);
            this.IndexTitleLb.TabIndex = 2;
            this.IndexTitleLb.Text = "Help Topics";
            // 
            // TextTitleLb
            // 
            this.TextTitleLb.AutoSize = true;
            this.TextTitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitleLb.Location = new System.Drawing.Point(134, 15);
            this.TextTitleLb.Name = "TextTitleLb";
            this.TextTitleLb.Size = new System.Drawing.Size(61, 20);
            this.TextTitleLb.TabIndex = 3;
            this.TextTitleLb.Text = "Help:  ";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 313);
            this.Controls.Add(this.TextTitleLb);
            this.Controls.Add(this.IndexTitleLb);
            this.Controls.Add(this.HelpTb);
            this.Controls.Add(this.HelpIndexLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HelpIndexLb;
        private System.Windows.Forms.TextBox HelpTb;
        private System.Windows.Forms.Label IndexTitleLb;
        private System.Windows.Forms.Label TextTitleLb;
    }
}