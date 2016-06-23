using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Extended
{
    public class ImagePreview
    {
        public static void Show(string path)
        {
            var frm = new ImagePreviewForm();
            frm.ImagePath = path;
            frm.ImageComment = "Please add Comment";
            frm.ShowDialog();
        }
    }
}
