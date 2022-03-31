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
    public partial class LibraryGUI : Form
    {
        Bitmap image = new Bitmap("C:/Users/cwieb255/pictures/guibg.jpg");
        
        public LibraryGUI()
        {
            InitializeComponent();
            pictureBoxImage.Image = image;
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonForwardImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.Image = image;
        }
    }
}
