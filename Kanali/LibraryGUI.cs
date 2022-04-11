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

namespace Kanali
{
    public partial class LibraryGUI : Form
    {
        String path;
        String[] Images;
        int Images_Index = 0;

        public LibraryGUI()
        {
            InitializeComponent();

            this.ActiveControl = labelImageIndex;

            // Events for keypresses
            labelImageIndex.KeyDown += LibraryGUI_KeyDown;

            User usr = new User();
            path = usr.getJson().download_path;

            // Appends all files via recursion to Images array
            Images = getImages(path);

            // Sets first image to the picturebox
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
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
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
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonForwardImage_Click(object sender, EventArgs e)
        {
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
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
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

        
    }
}
