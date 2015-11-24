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
using System.Windows.Forms.DataVisualization.Charting;

namespace PhotoEditor
{
    public struct Data
    {
        public double R_Val;
        public double B_Val;
        public double G_Val;
    }

    class PixelOperations
    {
        GeometryOperations trans_pic ;
        public PixelOperations()
        {
            trans_pic = new GeometryOperations();
        }

        private Data[] Histogram_data(int width, int height, Color[,] Org_Buffer)
        {
            Data[] Hist_Data = new Data[256];
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    ++Hist_Data[Org_Buffer[i, j].R].R_Val;
                    ++Hist_Data[Org_Buffer[i, j].G].B_Val;
                    ++Hist_Data[Org_Buffer[i, j].B].G_Val;
                }
            }
            Data[] Norm_Hist_Data = Hist_Normalize(Hist_Data);
            return Norm_Hist_Data;
        }

        private Data[] Hist_Normalize(Data[] Hist_Data)
        {
            Data maxRGB = get_max_value(Hist_Data);
            Data[] Norm_Hist_Data = new Data[256];
            for (int i = 0; i < 256; ++i)
            {
                Norm_Hist_Data[i].R_Val = ((Hist_Data[i].R_Val / maxRGB.R_Val) * 256);
                Norm_Hist_Data[i].G_Val = ((Hist_Data[i].G_Val / maxRGB.G_Val) * 256);
                Norm_Hist_Data[i].B_Val = ((Hist_Data[i].B_Val / maxRGB.B_Val) * 256);
            }
            return Norm_Hist_Data;
        }

        private Data get_max_value(Data[] Hist_Data)
        {
            Data maxRGB = new Data();
            for (int i = 0; i < 256; ++i)
            {
                if (Hist_Data[i].R_Val > maxRGB.R_Val)
                    maxRGB.R_Val = Hist_Data[i].R_Val;
                if (Hist_Data[i].G_Val > maxRGB.G_Val)
                    maxRGB.G_Val = Hist_Data[i].G_Val;
                if (Hist_Data[i].B_Val > maxRGB.B_Val)
                    maxRGB.B_Val = Hist_Data[i].B_Val;
            }
            return maxRGB;
        }

        public double cutOff(double val)
        {
            if (val > 255)
                val = 255;
            else if (val < 0)
                val = 0;
            return val;
        }
        //for contrast to get the min and max range
        private void Min_Max_Value(Color[,] Org_Buffer, out Data Min, out Data Max)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Min.B_Val = Min.R_Val = Min.G_Val = 255;
            Max.B_Val = Max.R_Val = Max.G_Val = 0;

            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    if (Org_Buffer[i, j].R < Min.R_Val)
                        Min.R_Val = Org_Buffer[i, j].R;
                    if (Org_Buffer[i, j].G < Min.G_Val)
                        Min.G_Val = Org_Buffer[i, j].G;
                    if (Org_Buffer[i, j].B < Min.B_Val)
                        Min.B_Val = Org_Buffer[i, j].B;
                    //   //   //   //   //   //
                    if (Org_Buffer[i, j].R > Max.R_Val)
                        Max.R_Val = Org_Buffer[i, j].R;
                    if (Org_Buffer[i, j].G > Max.G_Val)
                        Max.G_Val = Org_Buffer[i, j].G;
                    if (Org_Buffer[i, j].B > Max.B_Val)
                        Max.B_Val = Org_Buffer[i, j].B;
                }
            }
        }

        private void Min_Max_Value(Data[,] Org_Buffer, out Data Min, out Data Max)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Min.B_Val = Min.R_Val = Min.G_Val = 255;
            Max.B_Val = Max.R_Val = Max.G_Val = 0;

            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    if (Org_Buffer[i, j].R_Val < Min.R_Val)
                        Min.R_Val = Org_Buffer[i, j].R_Val;
                    if (Org_Buffer[i, j].G_Val < Min.G_Val)
                        Min.G_Val = Org_Buffer[i, j].G_Val;
                    if (Org_Buffer[i, j].B_Val < Min.B_Val)
                        Min.B_Val = Org_Buffer[i, j].B_Val;
                    //   //   //   //   //   //
                    if (Org_Buffer[i, j].R_Val > Max.R_Val)
                        Max.R_Val = Org_Buffer[i, j].R_Val;
                    if (Org_Buffer[i, j].G_Val > Max.G_Val)
                        Max.G_Val = Org_Buffer[i, j].G_Val;
                    if (Org_Buffer[i, j].B_Val > Max.B_Val)
                        Max.B_Val = Org_Buffer[i, j].B_Val;
                }
            }
        }

        public Color[,] Resize(Color[,] image, int width2, int height2)
        {
            int width1 = image.GetLength(0);
            int height1 = image.GetLength(1);
            float Sx = (float)width1 / (float)width2;
            float Sy = (float)height1 / (float)height2;
            return trans_pic.scale(image, Sx, Sy);
        }
        
        //Normalization int Data type [overloaded Function]
        public Color[,] Contrast(int NewMin, int NewMax, Data[,] Org_Buffer)
        {
            //NewVal = [(OldVal – OldMin)/(OldMax – OldMin)] × (NewMax – NewMin) + NewMin
            Data OldMin, OldMax;
            Min_Max_Value(Org_Buffer, out OldMin, out OldMax);
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            Data data;
            //IMPORTANT ==> we Suppose that NewMax & NewMin is one for R & G & B .. the user Enter one value fo 3 colors
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    data.R_Val = (((Org_Buffer[i, j].R_Val - OldMin.R_Val) / (OldMax.R_Val - OldMin.R_Val)) * (NewMax - NewMin) + NewMin);
                    data.R_Val = cutOff(data.R_Val);

                    data.G_Val = (((Org_Buffer[i, j].G_Val - OldMin.G_Val) / (OldMax.G_Val - OldMin.G_Val)) * (NewMax - NewMin) + NewMin);
                    data.G_Val = cutOff(data.G_Val);

                    data.B_Val = (((Org_Buffer[i, j].B_Val - OldMin.B_Val) / (OldMax.B_Val - OldMin.B_Val)) * (NewMax - NewMin) + NewMin);
                    data.B_Val = cutOff(data.B_Val);

                    Org_Buffer_temp[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Org_Buffer_temp;
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public void drawHistogram(Chart chart, Color[,] Org_Buffer)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Data[] data = Histogram_data(width, height, Org_Buffer);
            for (int i = 0; i < 256; ++i)
            {
                chart.Series["All"].Points.AddXY(i, data[i].R_Val);
            }
        }

        public Color[,] Brightness(int offset, Color[,] Org_Buffer)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            Data data;
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    data.R_Val = Org_Buffer[i, j].R + offset;
                    data.R_Val = cutOff(data.R_Val);

                    data.G_Val = Org_Buffer[i, j].G + offset;
                    data.G_Val = cutOff(data.G_Val);

                    data.B_Val = Org_Buffer[i, j].B + offset;
                    data.B_Val = cutOff(data.B_Val);

                    Org_Buffer_temp[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Org_Buffer_temp;
        }

        public Color[,] Contrast(int NewMin, int NewMax, Color[,] Org_Buffer)
        {
            //NewVal = [(OldVal – OldMin)/(OldMax – OldMin)] × (NewMax – NewMin) + NewMin
            Data OldMin, OldMax;
            Min_Max_Value(Org_Buffer, out OldMin, out OldMax);
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            Data data;
            //IMPORTANT ==> we Suppose that NewMax & NewMin is one for R & G & B .. the user Enter one value fo 3 colors
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    data.R_Val = (((Org_Buffer[i, j].R - OldMin.R_Val) / (OldMax.R_Val - OldMin.R_Val)) * (NewMax - NewMin) + NewMin);
                    data.R_Val = cutOff(data.R_Val);

                    data.G_Val = (((Org_Buffer[i, j].G - OldMin.G_Val) / (OldMax.G_Val - OldMin.G_Val)) * (NewMax - NewMin) + NewMin);
                    data.G_Val = cutOff(data.G_Val);

                    data.B_Val = (((Org_Buffer[i, j].B - OldMin.B_Val) / (OldMax.B_Val - OldMin.B_Val)) * (NewMax - NewMin) + NewMin);
                    data.B_Val = cutOff(data.B_Val);

                    Org_Buffer_temp[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Org_Buffer_temp;
        }

        public Color[,] Gray(Color[,] Org_Buffer)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            double sum;
            Data data;
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    sum = Org_Buffer[i, j].R + Org_Buffer[i, j].G + Org_Buffer[i, j].B;
                    data.R_Val = sum / 3;
                    data.G_Val = sum / 3;
                    data.B_Val = sum / 3;
                    Org_Buffer_temp[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Org_Buffer_temp;
        }

        public Color[,] Not(Color[,] Org_Buffer)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            Data data;
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    data.R_Val = 255 - Org_Buffer[i, j].R;
                    data.G_Val = 255 - Org_Buffer[i, j].G;
                    data.B_Val = 255 - Org_Buffer[i, j].B;
                    Org_Buffer_temp[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Org_Buffer_temp;
        }

        public Color[,] Add(Color[,] image1, Color[,] image2, float fraction)
        {
            int width = image1.GetLength(0);
            int height = image1.GetLength(1);
            Color[,] Pic_After_Addtion = new Color[width, height];
            Data data;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    data.R_Val = image1[i, j].R * fraction + image2[i, j].R * (1 - fraction);
                    data.G_Val = image1[i, j].G * fraction + image2[i, j].G * (1 - fraction);
                    data.B_Val = image1[i, j].B * fraction + image2[i, j].B * (1 - fraction);
                    Pic_After_Addtion[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Pic_After_Addtion;
        }

        public Color[,] sub(Color[,] image1, Color[,] image2)
        {
            int width = image1.GetLength(0);
            int height = image1.GetLength(1);
            Color[,] Pic_After_subtraction = new Color[width, height];
            float R = 0, G = 0, B = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (image1[i, j].R > image2[i, j].R)
                        R = image1[i, j].R - image2[i, j].R;
                    else
                        R = image2[i, j].R - image1[i, j].R;
                    if (image1[i, j].G > image2[i, j].G)
                        G = image1[i, j].G - image2[i, j].G;
                    else
                        G = image2[i, j].G - image1[i, j].G;
                    if (image1[i, j].B > image2[i, j].B)
                        B = image1[i, j].B - image2[i, j].B;
                    else
                        B = image2[i, j].B - image1[i, j].B;
                    Pic_After_subtraction[i, j] = Color.FromArgb((int)R, (int)G, (int)B);
                }
            }
            return Pic_After_subtraction;
        }

        public Color[,] Gamma(Color[,] Org_Buffer, double Gamma_value)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);
            Color[,] Org_Buffer_temp = new Color[width, height];
            Data[,] RGB = new Data[width, height];
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    RGB[i, j].R_Val = Math.Pow(Org_Buffer[i, j].R, Gamma_value);
                    RGB[i, j].G_Val = Math.Pow(Org_Buffer[i, j].G, Gamma_value);
                    RGB[i, j].B_Val = Math.Pow(Org_Buffer[i, j].B, Gamma_value);
                }
            }
            Org_Buffer_temp = Contrast(0, 255, RGB);
            return Org_Buffer_temp;
        }

        public Bitmap bit_plane_slicing(Color[,] buffer, int _one_byte, string type)
        {
            Picture p = new Picture();
            int width = buffer.GetLength(0);
            int height = buffer.GetLength(1);
            Color[,] res = new Color[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (type == "r")
                    {
                        int result = _one_byte & buffer[i, j].R;
                        if (result == _one_byte)
                            res[i, j] = Color.FromArgb(255, 0, 0);
                        else
                            res[i, j] = Color.FromArgb(0, 0, 0);

                    }
                    else if (type == "g")
                    {
                        int result = _one_byte & buffer[i, j].G;
                        if (result == _one_byte)
                            res[i, j] = Color.FromArgb(0, 255, 0);
                        else
                            res[i, j] = Color.FromArgb(0, 0, 0);
                    }
                    else if (type == "b")
                    {
                        int result = _one_byte & buffer[i, j].B;
                        if (result == _one_byte)
                            res[i, j] = Color.FromArgb(0, 0, 255);
                        else
                            res[i, j] = Color.FromArgb(0, 0, 0);
                    }
                }
            }
            return p.convert_Buffer_to_Bitmap(res, res.GetLength(0), res.GetLength(1));
        }

        public Color[,] Quantization_R(Color[,] buffer, int red_value)
        {
            int width = buffer.GetLength(0);
            int height = buffer.GetLength(1);

            Color[,] res = new Color[width, height];
            int r = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (red_value != 0)
                        r = buffer[i, j].R & red_value;
                    else
                        r = buffer[i, j].R;
                    res[i, j] = Color.FromArgb(r, buffer[i, j].G, buffer[i, j].B);
                }
            }
            return res;
        }

        public Color[,] Quantization_G(Color[,] buffer, int green_value)
        {
            int width = buffer.GetLength(0);
            int height = buffer.GetLength(1);

            Color[,] res = new Color[width, height];
            int g = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (green_value != 0)
                        g = buffer[i, j].G & green_value;
                    else
                        g = buffer[i, j].G;
                    res[i, j] = Color.FromArgb(buffer[i, j].R, g, buffer[i, j].B);
                }
            }
            return res;
        }

        public Color[,] Quantization_B(Color[,] buffer, int blue_value)
        {
            int width = buffer.GetLength(0);
            int height = buffer.GetLength(1);

            Color[,] res = new Color[width, height];
            int b = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (blue_value != 0)
                        b = buffer[i, j].B & blue_value;
                    else
                        b = buffer[i, j].B;
                    res[i, j] = Color.FromArgb(buffer[i, j].R, buffer[i, j].G, b);
                }
            }
            return res;
        }

    }
}
