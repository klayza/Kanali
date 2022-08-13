using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Kanali
{
    public partial class MainFormGUI : Form
    {
        User usr = new User();
        public MainFormGUI()
        {
            // Start button will be grayed out if there is no config
            InitializeComponent();
            mediaScrolling();
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
        private String getFavorites()
        {
            if (File.Exists("Favorites.txt"))
            {
                string str = File.ReadAllText("Favorites.txt");
                return str;

            }
            File.Create("Favorites.txt").Close();
            return "";
        }

        public async void WaitSomeTime(String[] favs, int time)
        {
            while (true)
            {
                foreach (string fav in favs)
                {
                    await Task.Delay(time);
                    Image img = new Bitmap(fav);
                    this.BackgroundImage = img;
                }
            }
        }

        private String[] getFavoritesList()
        {
            String raw;

            if (File.Exists("Favorites.txt") == false)
            {
                return null;
            }
            else if (File.ReadAllText("Favorites.txt") == "")
            {
                return null;
            }

            raw = File.ReadAllText("Favorites.txt");

            String[] ls = raw.Split('*');
            List<string> lst = ls.ToList();
            lst.Remove("");

            return lst.ToArray();
        }

        private void mediaScrolling()
        {
            User json = usr.getJson();
            if (json.media_scrolling)
            {
                int time = 5000;
                var favs = getFavoritesList();
                if (favs == null)
                {
                    return;
                }

                if (favs.Length < 4)
                {
                    time = 10000;
                }

                WaitSomeTime(favs, 5000);
                
            }
        }
    }
}
