using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class ImagePreviewForm : Form
    {
        public string ImagePath;
        public string ImageComment;
        public ImagePreviewForm()
        {
            InitializeComponent();
        }

        private void showImage()
        {
            pctImage.ImageLocation = ImagePath;
        }

        private void ImagePreviewForm_Load(object sender, EventArgs e)
        {
            showImage();
        }
    }
}
