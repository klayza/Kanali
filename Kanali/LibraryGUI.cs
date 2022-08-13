using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanali
{

    /*  Flow ('favorite' button)
     *   
     *  1. Before displaying an image checks if an image is favorited
     *  2. If already favorited, changes text of favorite button to 'Unfavorite'
    */
    public partial class LibraryGUI : Form 
    {
        String path;
        String[] Images;
        String Favorites;
        int Images_Index = 0;

        public LibraryGUI()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Selectable, false);
            this.ActiveControl = label1;

            User usr = new User();
            path = usr.getJson().download_path;

            // Events for keypresses
            label1.KeyDown += LibraryGUI_KeyDown;

            // Appends all files via recursion to Images array
            Images = getImages(path);

            this.Favorites = getFavorites();

            // Sets first image to the picturebox
            if (this.Favorites.Contains(Images[Images_Index]))
            {
                this.buttonFavorite.BackColor = Color.Red;
            }
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
            displayImageIndex();
        }

        private void LibraryGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                buttonBackImage.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                buttonForwardImage.PerformClick();
            }
            else if (e.KeyCode == Keys.F)
            {
                buttonFavorite.PerformClick();
            }

        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
            label1.Focus();
            this.buttonFavorite.BackColor = Color.White;
            if (Images_Index == 0)
            {
                Images_Index = Images.Length - 1;
            }
            else
            {
                Images_Index--;
            }
            displayImageIndex();
            changeTitle(Images[Images_Index]);
            if (this.Favorites.Contains(Images[Images_Index]))
            {
                this.buttonFavorite.BackColor = Color.Red;
            }
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonForwardImage_Click(object sender, EventArgs e)
        {
            label1.Focus();
            this.buttonFavorite.BackColor = Color.White;
            if (Images_Index == Images.Length - 1)
            {
                Images_Index = 0;
            }
            else
            {
                Images_Index++;
            }
            displayImageIndex();
            changeTitle(Images[Images_Index]);
            if (this.Favorites.Contains(Images[Images_Index]))
            {
                this.buttonFavorite.BackColor = Color.Red;
            }
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (pictureBoxImage.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                pictureBoxImage.SizeMode = PictureBoxSizeMode.Normal;
                return;
            }
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);

        }

        // Displays the current index of image ex. 1 / 5
        private void displayImageIndex()
        {
            labelImageIndex.Text = (Images_Index + 1).ToString() + " / " + Images.Length.ToString();
        }

        private void buttonZoomToFit_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (pictureBoxImage.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBoxImage.SizeMode = PictureBoxSizeMode.Normal;
                return;
            }
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
            
            
        }

        private String[] getImages(String path)
        {
            List<String> _images = new List<String>();

            String[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                String extension = files[i].Substring(files[i].Length - 4);
                if (extension == ".jpg" || extension == ".png")
                {
                    _images.Add(files[i]);
                }
                else
                {
                    continue;
                }
            }
            return _images.ToArray();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainFormGUI mainFormGUI = new MainFormGUI();
            mainFormGUI.Show();
            this.Close();
        }

        private void changeTitle(String name)
        {
            this.Text = name;
            this.Update();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            label1.Focus();
            var rnd = new Random();
            Images = Images.OrderBy(item => rnd.Next()).ToArray();
        }

        private void buttonFavorite_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (this.buttonFavorite.BackColor == Color.Red)
            {
                removeFavorite(Images[Images_Index]);
                this.buttonFavorite.BackColor = Color.White;
                return;
            }
            addFavorite(Images[Images_Index]);
            this.buttonFavorite.BackColor = Color.Red;
        }
        private void addFavorite(string path)
        {
            string favs = getFavorites();
            this.Favorites += "*" + path;
            favs += "*" + path;
            File.WriteAllText("Favorites.txt", favs);
        }

        private void removeFavorite(string path)
        {
            string favs = getFavorites();
            if (favs.Contains(path))
            {
                favs = favs.Replace("*" + path, "");
                File.WriteAllText("Favorites.txt", favs);
                this.Favorites = favs;
            }
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
        
        // IGNORE
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // IGNORE
        private void LibraryGUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString().ToLower())
            {
                case "a":
                    buttonBackImage.PerformClick();
                    break;
                case "f":
                    buttonForwardImage.PerformClick();
                    break;
                case "e":
                    buttonFavorite.PerformClick();
                    break;
                default:
                    break;
            }
        }

    }
}
