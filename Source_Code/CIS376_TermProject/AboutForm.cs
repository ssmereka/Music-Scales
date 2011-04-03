using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS376_TermProject
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            aboutLbl.Text = "Developed by Scott Smereka and Corey Maylone\r\n";
            aboutLbl.Text += "University of Michigan - Dearborn\r\n";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
