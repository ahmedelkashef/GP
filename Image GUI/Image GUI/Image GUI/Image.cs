using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Image : Form
    {
        public Image()
        {
            InitializeComponent();
        }
        Bitmap b;
        private void Image_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = b;
        }
        public Image(Bitmap im)
        {
            b = im;
            InitializeComponent();
        }

        private void CMS_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
