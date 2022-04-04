﻿using System;
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
        String path = "C:/Users/cwieb255/desktop/Tree";
        Bitmap image = new Bitmap("C:/Users/cwieb255/pictures/guibg.jpg");
        String[] Images;
        int Images_Index = 0;

        public LibraryGUI()
        {
            InitializeComponent();

            // Appends all files via recursion to Images array
            Images = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            // Sets first image to the picturebox
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
            displayImageIndex();
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
            if (Images_Index == 0)
            {
                Images_Index = Images.Length - 1;
            }
            displayImageIndex();
            Images_Index--;
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonForwardImage_Click(object sender, EventArgs e)
        {
            if (Images_Index == Images.Length - 1)
            {
                Images_Index = 0;
            }
            Images_Index++;
            displayImageIndex();
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
    }
}
