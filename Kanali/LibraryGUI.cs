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
        String path = "C:/Users/cwieb255/desktop/Tree";
        Bitmap image = new Bitmap("C:/Users/cwieb255/pictures/guibg.jpg");
        String[] Images;
        int Images_Index = 0;

        public LibraryGUI()
        {
            InitializeComponent();
            Images = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
            Images_Index--;
        }

        private void buttonForwardImage_Click(object sender, EventArgs e)
        {
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
            Images_Index++;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.Image = new Bitmap(Images[Images_Index]);
        }
    }
}
