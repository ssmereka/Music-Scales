using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace CIS376_TermProject
{
    public partial class MainForm : Form
    {

        String CurScaleType = null;  //Current Active Scale Type (Major or Minor)
        String CurScaleRoot = null;  //Current Active Scale Root ([Sharp or Flat]:  A, B, C, D, E, F, G)
        HelpForm helpForm = new HelpForm();
        TutorialForm tutorialForm = new TutorialForm();
        AboutForm aboutForm = new AboutForm();
        
        public MainForm()
        {
            InitializeComponent();
            ScaleLbl.Text = "Scale:  ";   //
            StatusTxt.Text = "Select Major or Minor scale type.";  //
        }

        private void ScaleRoot_Changed(object sender, EventArgs e)
        {
            CurScaleRoot = rootLb.SelectedItem.ToString();
            generateScale();
        }

        private void generateScale()
        {
            if (rootLb.SelectedItem != null)
            {
                ArrayList list = new ArrayList();
                Scale s = new Scale();
                list = s.getScale(CurScaleRoot, CurScaleType);
                //outputTxt.Text = CurScaleRoot + " " + CurScaleType + " Scale:\r\n";
                ScaleLbl.Text = "Scale:  " + CurScaleRoot + " " + CurScaleType;
                outputTxt.Text = "";
                foreach (object o in list)
                {
                    if (o != null)
                    {
                        outputTxt.Text += o.ToString() + "\r\n";
                    }
                }
            }
        }

        private void ScaleType_CheckedChanged(object sender, EventArgs e)
        {
            MusicData md = new MusicData();

            StatusTxt.Text = "Select a root note or another scale type.";

            if (MajorRb.Checked)
            {
                CurScaleType = "Major";
                rootLb.DataSource = md.getMajorRoots();
            }
            else if (MinorRb.Checked)
            {
                CurScaleType = "Minor";
                rootLb.DataSource = md.getMinorRoots();
            }
            else
            {
                MessageBox.Show("An Error has occurred while selecting scale type, please reselect a Scale Type.");
                return;  //Error if reached here
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (outputTxt.Text != "")
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Title = "Select a file name and location.";
                saveFileDialog1.DefaultExt = "txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        StreamWriter wText = new StreamWriter(myStream);
                        wText.WriteLine("Scale:  " + CurScaleRoot + " " + CurScaleType);
                        wText.Write(outputTxt.Text);
                        wText.Flush();
                        wText.Close();
                        myStream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no scales to export.  Please, first select a scale type and root");
            }

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusSb.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void ViewHelpForm(object sender, EventArgs e)
        {
            if (!helpForm.Visible)
            {
                helpForm = new HelpForm();
                helpForm.Show();
            }
        }

        private void ViewTutorialForm(object sender, EventArgs e)
        {
            if (!tutorialForm.Visible)
            {
                tutorialForm = new TutorialForm();
                tutorialForm.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!aboutForm.Visible)
            {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 New updates are available");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
