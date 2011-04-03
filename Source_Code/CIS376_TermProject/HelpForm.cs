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
    public partial class HelpForm : Form
    {
        String CurTopic = null;  //

        public HelpForm()
        {
            InitializeComponent();
            loadHelpTopics();
            HelpIndexLb.SelectedIndex = 0;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void HelpIndexLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurTopic = HelpIndexLb.SelectedItem.ToString();
            if (CurTopic != null)
            {
                TextTitleLb.Text = "Help:  " + CurTopic.Substring(3, CurTopic.Length - 3);
            }
            switch (CurTopic.ToLower())
            {
                case "1. getting started":
                    HelpTb.Text = "How to generate a scale?\r\n\r\n" +
                                  "1.  A scale type must first be chosen (Major or Minor).\r\n" +
                                  "2.  A scale root must be chosen (A, B, C, ...).\r\n" +
                                  "3.  Upon selection of the root note a scale will be generated and displayed.\r\n";
                    break;
                case "2. scale type":
                    HelpTb.Text = "Scale Type - Allows you to choose between majors scales or minor scales.  " +
                                  "A major scale is one whose third degree is a major third above the tonic, " +
                                  "while a minor scale has a minor third degree.\r\n\r\n";
                    HelpTb.Text += "Select the Major or Minor radio buttons in order to list all possible root notes.  " +
                                   "To select Major or Minor simply click on the text/radio button with your cursor.";
                    break;
                case "3. scale root":
                    HelpTb.Text = "Scale Root - Allows you to select a root note to construct the desired scale.  " +
                                   "Every scale has a root in which it starts and ends on.\r\n\r\n";
                    HelpTb.Text += "After a scale type has been chosen, " +
                                   "select a root note from the list-box in order to display the desired scale.  " +
                                   "To select a root note simply click on the note with your cursor.";
                    break;
                case "4. export to file":
                    HelpTb.Text = "Export to File - Allows you to export the generated scale to a text file.\r\n\r\n";
                    HelpTb.Text += "First generate a scale by selecting a Scale Type and Scale Root note.  ";
                    HelpTb.Text += "Next right click on the Scale Output box or go to File and select Export to Text File.  ";
                    HelpTb.Text += "When a save file dialog box is displayed enter a location and file name, then select save.  ";
                    break;
                case "5. menu options":
                    HelpTb.Text = "Menu Item -> File -> Update\r\n";
                    HelpTb.Text += "Select update in order to check online, download, and install any available updates.\r\n\r\n";

                    HelpTb.Text += "Menu Item -> File -> Export to Text File\r\n";
                    HelpTb.Text += "see \"Export to File\"\r\n\r\n";

                    HelpTb.Text += "Menu Item -> File -> Exit\r\n";
                    HelpTb.Text += "Selecting this will exit the program.\r\n\r\n";

                    HelpTb.Text += "Menu Item -> View -> Status Bar\r\n";
                    HelpTb.Text += "If \"Status Bar\" is checked a bar at the bottom of the application  " +
                                   "will be displayed with helpful instructions.\r\n\r\n";

                    HelpTb.Text += "Menu Item -> Help -> Tutorial\r\n";
                    HelpTb.Text += "Displays a tutorial on how to use the program.\r\n\r\n";

                    HelpTb.Text += "Menu Item -> Help -> View Help\r\n";
                    HelpTb.Text += "Displays this help menu.\r\n\r\n";

                    HelpTb.Text += "Menu Item -> Help -> About\r\n";
                    HelpTb.Text += "Displays information about the creation of the program.";

                    break;
                default: HelpTb.Text = "Select a help topic to display.";
                    break;
            }
        }

        private void loadHelpTopics()
        {
            HelpIndexLb.Items.Add("1. Getting Started");
            HelpIndexLb.Items.Add("2. Scale Type");
            HelpIndexLb.Items.Add("3. Scale Root");
            HelpIndexLb.Items.Add("4. Export to File");
            HelpIndexLb.Items.Add("5. Menu Options");
        }

        private void HelpTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
