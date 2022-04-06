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
        public SettingsGUI()
        {
            InitializeComponent();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            // Check if the user entered anything
            if (textBoxDownloadDirectory.Text == "")
            {
                return;
            }
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {    
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            textBoxDownloadDirectory.Text = this.folderBrowserDialog1.SelectedPath;
        }
    }
}
