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
    public partial class Filters : Form
    {
        Bitmap temp ;
        public Filters()
        {
            InitializeComponent();
        }
        public Filters(Bitmap b)
        {
            InitializeComponent();
            pic_original.Image = b;
            pic_modified.Image = b;
            temp = b;
        }
        int type_v = 2;
        public Filters(string type , Bitmap b)
        {
            if (type == "Mean")
            {
                type_v = 1;
            }
            
            InitializeComponent();
            pic_original.Image = b;
            pic_modified.Image = b;
            temp = b;
        }
        private void Filters_Load(object sender, EventArgs e)
        {
            if (type_v == 1)
            {
                GroupBoxControl(groupBox_mask, groupBox_sigma);
                GroupBoxControl(groupBox_mask, groupBox_options);
            }
        }
        private void GroupBoxControl(GroupBox show, GroupBox hide)
        {
            show.Visible = true;
            hide.Visible = false;
        }

        private void radioButton_Option_1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_mask.Visible = true;
            type_v = 2;
        }

        private void radioButton_Option_2_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxControl( groupBox_sigma,groupBox_mask);
            type_v = 3;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            NeighborOperations Filters = new NeighborOperations();
            Picture pic = new Picture(); 
            
           Color [,] input = pic.Buffering(temp);

            if (type_v == 1)
            { //mean filter
                Color[,] Result = Filters.MeanFilter(input, int.Parse(MaskWidth.Text), int.Parse(MaskHeight.Text), int.Parse(OrignX.Text), int.Parse(OriginY.Text));
                temp = pic.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));
                pic_modified.Image = temp;
            
            }
            else if (type_v == 2)
            { //gaussian option1 
                Color[,] Result = Filters.GaussianFilter1(input,int.Parse(MaskWidth.Text),double.Parse(Sigma.Text),int.Parse(OrignX.Text), int.Parse(OriginY.Text));
                temp = pic.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));
                pic_modified.Image = temp;
            }
            else if (type_v == 3)
            { //gaussian option2 

                Color[,] Result = Filters.GaussianFilter2(input, double.Parse(Sigma.Text), int.Parse(OrignX.Text), int.Parse(OriginY.Text));
               
                temp = pic.convert_Buffer_to_Bitmap(Result, Result.GetLength(0), Result.GetLength(1));
                pic_modified.Image = temp;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
         
            pic_original.Image = pic_modified.Image;
           
      

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
          pic_modified.Image  = pic_original.Image ;
        }

       
    }
}
