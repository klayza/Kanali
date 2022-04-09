using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanali
{
    public partial class SettingsGUI : Form
    {
        String path;
        public SettingsGUI()
        {
            InitializeComponent();

            Config cf = new Config();
            if (cf.initialized)
            {
                Config json = cf.getJson();

                // Sets the widgets to their values retrieved from getJson() in Config class
                textBoxDownloadDirectory.Text = json.download_path;
                checkBoxMediaScrolling.Checked = json.media_scrolling;
            }
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            // Check if the user entered anything
            if (textBoxDownloadDirectory.Text == "")
            {
                MessageBox.Show("Choose a valid path");
                return;
            }

            // Retrieves the values from widgets then creates a new Preferences.json file with those values
            config.download_path = textBoxDownloadDirectory.Text;
            config.media_scrolling = checkBoxMediaScrolling.Checked;
            config.createJson(config);
            this.Hide();
        }

        // Opens prompt for user to choose a directory then adds to text box
        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {    
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            textBoxDownloadDirectory.Text = this.folderBrowserDialog1.SelectedPath;
        }
    }
}
