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
    public partial class MainFormGUI : Form
    {
        public MainFormGUI()
        {
            // Start button will be grayed out if there is no config
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Will run python scripts
            // Change button red, and turn text to stop

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            // Allow the user config search queries
            ConfigGUI configGUI = new ConfigGUI();
            configGUI.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close scripts
            Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsGUI settingsgui = new SettingsGUI();
            settingsgui.Show();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            // Opens a txt with log
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            // Opens library (picture viewer)
            LibraryGUI libraryGUI = new LibraryGUI();
            libraryGUI.Show();
            this.Hide();
        }
    }
}
