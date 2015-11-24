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
    public partial class Form1 : Form
    {
        Picture p;
        Color[,] org_Buffer;
        Color[,] final_image;
        Bitmap b;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Bitmap image)
        {
            InitializeComponent();
      
            ControlTab.SelectedTab.BackgroundImage = image;
        }
       
        private void adjactementsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            BrightnessAndContrast BC = new BrightnessAndContrast(b);
            //BC.MdiParent = this;
            BC.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(groupBox_gamma, groupBox1, SharpenGB, "Gamma");
           
        }

        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            Quantaization quant = new Quantaization(b);
           // quant.MdiParent = this;
            quant.ShowDialog();
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void GroupBoxControl(GroupBox show, GroupBox hide, GroupBox hide2, string text)
        {
            show.Visible = true;
            hide.Visible = false;
            hide2.Visible = false;
            show.Text = text;
        }
        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(groupBox1, SharpenGB,groupBox_gamma, "Rotate");
            label1.Text = "Rotate angle";
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Scale");
        }

        private void shearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Shear");

        }

        private void horizontalEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Horizontal->Original Orign");

        }

        private void verticalFiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Vertical->Original Orign");

        }

        private void magnitudeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Magnitude->Original Orign");

        }
        private void sharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBoxControl(SharpenGB, groupBox1, groupBox_gamma, "Laplacian Sharpening->Original Orign");

        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            Filters meanFilter = new Filters("Mean",b);
           // meanFilter.MdiParent = this;
            meanFilter.Show();
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            Filters meanFilter = new Filters(b);
           // meanFilter.MdiParent = this;
            meanFilter.Show();
        }
        private void create_tabPage(Bitmap d,string img_name)
        {
            TabPage tabpage = new TabPage();

            tabpage.BorderStyle = BorderStyle.Fixed3D;
            tabpage.Text = img_name;
            ControlTab.TabPages.Add(tabpage);
            
            tabpage.BackgroundImage = d ;
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            tabpage.BackgroundImageLayout = ImageLayout.None;

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = new Picture();
            string path = p.showDialog();
            if (path != null)
            {
                string[] seperator = { "\\" };
                string[] arr = path.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                string img_name = arr[arr.Length - 1];
                b = new Bitmap(path);
                path = null;
                org_Buffer = p.Buffering(b); 
                final_image = org_Buffer;
                //pictureBox25.Image = b;
                ControlTab.Visible = true;
                create_tabPage(b, img_name);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
     
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Control_Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void Item_Clicked(object sender, EventArgs e)
        {

            for (int i = 0; i <  ControlTab.TabCount; i++)
            {
                Rectangle rect = ControlTab.GetTabRect(i);
                if (rect.Contains(this.PointToClient(Cursor.Position)))
                {
                    ControlTab.TabPages.RemoveAt(i);
                }
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                contextMenuStrip1.Show(Cursor.Position); 
            }
          //  MessageBox.Show("nooo");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           // contextMenuStrip1.Items.Add("Close", null, new EventHandler(Item_Clicked));
          //  MessageBox.Show("open");

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                ControlTab.SelectedTab.Hide();

        }

        private void motionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motion m = new Motion();
           // m.MdiParent = this;
            m.ShowDialog();
        }

        private void add2ImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlgebraForm alg = new AlgebraForm();
            alg.ShowDialog();
        }

        private void trackBar_gamma_Scroll(object sender, EventArgs e)
        {
            numericUpDown_gamma.Value = trackBar_gamma.Value;

        }

        private void btn_apply_gamma_Click(object sender, EventArgs e)
        {
            PixelOperations gamma = new PixelOperations();
            b = (Bitmap)ControlTab.SelectedTab.BackgroundImage;
            final_image = gamma.Gamma(p.Buffering(b), (double)numericUpDown_gamma.Value);
          
            b = p.convert_Buffer_to_Bitmap(final_image, final_image.GetLength(0), final_image.GetLength(1));

            ControlTab.SelectedTab.BackgroundImage = b;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sharpen EdgeDetector = new Sharpen();
            Color[,] input = p.Buffering(b);

            if (SharpenGB.Text == "Horizontal->Original Orign")
            {
               
              Color[,] Result = EdgeDetector.SobelHorizontal(input, int.Parse(Origin_X.Text), int.Parse(Origin_y.Text));
               ControlTab.SelectedTab.BackgroundImage = p.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));
            
            
            }
            else if (SharpenGB.Text == "Vertical->Original Orign")
            {
             
                Color[,] Result = EdgeDetector.SobelVertical(input, int.Parse(Origin_X.Text), int.Parse(Origin_y.Text));
                ControlTab.SelectedTab.BackgroundImage = p.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));
            
            }
            else if (SharpenGB.Text == "Magnitude->Original Orign")
            {
                
                Color[,] V = EdgeDetector.SobelVertical(input, int.Parse(Origin_X.Text), int.Parse(Origin_y.Text));
                 Color[,] H = EdgeDetector.SobelHorizontal(input, int.Parse(Origin_X.Text), int.Parse(Origin_y.Text));
                 Color[,] Result = EdgeDetector.Magintude(H, V);
                ControlTab.SelectedTab.BackgroundImage = p.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));

            }
            else if (SharpenGB.Text == "Laplacian Sharpening->Original Orign")
            {
               
                Color[,] Result = EdgeDetector.laplacian(input, int.Parse(Origin_X.Text), int.Parse(Origin_y.Text));
                ControlTab.SelectedTab.BackgroundImage = p.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));

            }
        }

    }
}
