using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace PhotoEditor
{
    class Picture
    {

        public string showDialog()
        {
            OpenFileDialog upload_img = new OpenFileDialog();
            upload_img.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif; *.bmp; *.ppm;";
            if (upload_img.ShowDialog() == DialogResult.OK)
            {
                return upload_img.FileName;
            }
            return null;
        }

        public Color[,] Buffering(Bitmap Image)
        {
            int width = Image.Width;
            int height = Image.Height;
            Color[,] ret_Buff = new Color[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    ret_Buff[i, j] = Color.FromArgb(Image.GetPixel(i, j).R, Image.GetPixel(i, j).G, Image.GetPixel(i, j).B);
                }
            }
            return ret_Buff;
        }

        public Bitmap convert_Buffer_to_Bitmap(Color[,] Buffer, int width, int height)
        {
            Bitmap Bmap = new Bitmap(width, height);
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int r = Buffer[i, j].R;
                    int g = Buffer[i, j].G;
                    int b = Buffer[i, j].B;
                    Color color = Color.FromArgb(r, g, b);
                    Bmap.SetPixel(i, j, color);
                }
            }
            return Bmap;
        }

        public void Read_Picture(string FileName)
        {
            string ext = System.IO.Path.GetExtension(FileName);
            if (ext.ToLower().Equals("ppm"))
            {
                Bitmap image = ReadPPM(FileName);
                Color[,] Org_buffer = Buffering(image);
            }
            else
            {
                Bitmap image = new Bitmap(FileName);
                Color[,] Org_buffer = Buffering(image);
            }
        }

        private Bitmap ReadPPM(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string Firstline = sr.ReadLine();
            sr.Close();
            fs.Close();
            if (Firstline.ToLower().Equals("p3"))
            {
                return readPPM3(FileName);
            }
            else if (Firstline.ToLower().Equals("p5"))
            {
                return readPPM5(FileName);
            }
            else if (Firstline.ToLower().Equals("p6"))
            {
                return readPPM6(FileName);
            }
            return null;
        }

        private Bitmap readPPM3(string FileName)
        {
            return new Bitmap(FileName);
        }

        private Bitmap readPPM5(string FileName)
        {
            return new Bitmap(FileName);
        }

        private Bitmap readPPM6(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);
            var reader = new BinaryReader(fs);
            if (reader.ReadChar() != 'P' || reader.ReadChar() != '6')
                return null;
            string _width = "", _height = "";
            char temp;
            reader.ReadChar();
            //to Neglect comments
            while ((temp = reader.ReadChar()) == '#')
            {
                while (reader.ReadChar() != '\n')
                    reader.Read();
            }
            //to read width and height of the image
            if (temp >= '0' && temp <= '9')
                _width += temp;
            while ((temp = reader.ReadChar()) != ' ')
                _width += temp;
            while ((temp = reader.ReadChar()) >= '0' && temp <= '9')
                _height += temp;
            //to read the size of each pixel
            string max = "";
            max += reader.ReadChar(); //2
            max += reader.ReadChar(); //5
            max += reader.ReadChar(); //5
            char x = reader.ReadChar(); // newline
            //to read each pixel in the file R G B
            max += x;
            int height = int.Parse(_height);
            int width = int.Parse(_width);
            Bitmap Bmap = new Bitmap(width, height);
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int r = int.Parse(reader.ReadByte().ToString());
                    int g = int.Parse(reader.ReadByte().ToString());
                    int b = int.Parse(reader.ReadByte().ToString());
                    Color color = Color.FromArgb(r, g, b);
                    Bmap.SetPixel(i, j, color);
                }
            }
            return Bmap;
        }
    }
}
