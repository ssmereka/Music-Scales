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
    public partial class TutorialForm : Form
    {
        public TutorialForm()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = "Tutorial.avi";
        }

        private void PlayTutorial()
        {
            double time = 20.0;
            if (time <= axWindowsMediaPlayer1.currentMedia.duration)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = time;
            }
        }
    }
}
