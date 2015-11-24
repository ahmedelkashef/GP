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

namespace PhotoEditor
{
    class NeighborOperations
    {
        public PixelOperations pixel = new PixelOperations();

        public Color[,] GaussianFilter1(Color[,] Org_Buffer, int MaskSize, double Sigma, int OrgX, int OrgY)
        {
            Gaussian filter = new Gaussian();
            double[,] GMask = filter.CalculateGaussianKernel(Sigma, MaskSize);
            GMask = filter.NormalizeMatrix(GMask);
            Color[,] Tmp_Buffer = LinearFilter(Org_Buffer, GMask, OrgX, OrgY, "None");
            return Tmp_Buffer;
        }

        public Color[,] GaussianFilter2(Color[,] Org_Buffer, double Sigma, int OrgX, int OrgY)
        {
            Gaussian filter = new Gaussian();
            double[,] GMask = filter.CalculateNormalizedkernal(Sigma);
            Color[,] Tmp_Buffer = LinearFilter(Org_Buffer, GMask, OrgX, OrgY, "None");
            return Tmp_Buffer;
        }

        public Color[,] MeanFilter(Color[,] Org_Buffer, int MaskWidth,int MaskHeight , int OrgX, int OrgY)
        {
            MeanFilter filter = new MeanFilter();
            double[,] MeanMask = filter.CalculateMeanFilter(MaskWidth, MaskHeight);

        Color[,] Tmp_Buffer = LinearFilter(Org_Buffer, MeanMask, OrgX, OrgY, "None");
        return Tmp_Buffer;
        }
        public Color[,] LaplacianFilter(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Sharpen sharpFilter = new Sharpen();
            return sharpFilter.laplacian(Org_Buffer, OriginX, OriginY);
        }

        public Color[,] SobelHorizontalFilter(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Sharpen sharpFilter = new Sharpen();
            return sharpFilter.SobelHorizontal(Org_Buffer, OriginX, OriginY);
        }

        public Color[,] SobelVerticalFilter(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Sharpen sharpFilter = new Sharpen();
            return sharpFilter.SobelVertical(Org_Buffer, OriginX, OriginY);
        }

        public Color[,] SobelMagintudeFilter(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Sharpen sharpFilter = new Sharpen();
            Color[,] Hor_Buffer = sharpFilter.SobelHorizontal(Org_Buffer, OriginX, OriginY);
            Color[,] Ver_Buffer = sharpFilter.SobelVertical(Org_Buffer, OriginX, OriginY);
            return sharpFilter.Magintude(Hor_Buffer, Ver_Buffer);
        }

        private Color[,] Padding(Color[,] Old_Buffer, double[,] Matrix, int OriginX, int OriginY)
        {
            int Width = Matrix.GetLength(0);
            int Height = Matrix.GetLength(1);
            int PadLeft, PadRight, PadUp, PadDown;
            PadLeft = OriginY;
            PadRight = Height - 1 - OriginY;
            PadUp = OriginX;
            PadDown = Width - 1 - OriginX;
            if (PadRight < 0) PadRight = 0;
            if (PadDown < 0) PadDown = 0;
            int Old_W = Old_Buffer.GetLength(0);
            int Old_H = Old_Buffer.GetLength(1);
            Color[,] NewBuffer = new Color[Old_W + PadUp + PadDown, Old_H + PadLeft + PadRight];


            for (int i = 0; i < Old_W; i++)
            {
                for (int j = 0; j < Old_H; j++)
                {
                    NewBuffer[i + PadUp, j + PadLeft] = Old_Buffer[i, j];
                }
            }
            return NewBuffer;
        }

        public Color[,] LinearFilter(Color[,] input, double[,] Mask, int originX, int originY, string Postprocessing)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            int mask_width = Mask.GetLength(0);
            int mask_height = Mask.GetLength(1);

            Color[,] temp = Padding(input, Mask, originX, originY);
            Color[,] result = new Color[width, height];
            Data[,] data = new Data[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Data sum;
                    sum.R_Val = sum.G_Val = sum.B_Val = 0;
                    for (int k = 0; k < mask_height; k++)
                    {
                        for (int m = 0; m < mask_width; m++)
                        {
                            sum.R_Val += Mask[m, k] * temp[i + m, j + k].R;
                            sum.G_Val += Mask[m, k] * temp[i + m, j + k].G;
                            sum.B_Val += Mask[m, k] * temp[i + m, j + k].B;
                        }
                    }
                    if (Postprocessing == "Cutoff")
                    {
                        sum.R_Val = pixel.cutOff(sum.R_Val);
                        sum.G_Val = pixel.cutOff(sum.G_Val);
                        sum.B_Val = pixel.cutOff(sum.B_Val);
                        result[i, j] = Color.FromArgb((int)sum.R_Val, (int)sum.G_Val, (int)sum.B_Val);

                    }
                    else if (Postprocessing == "Absolute")
                    {

                        sum.R_Val = Math.Abs(sum.R_Val);
                        sum.G_Val = Math.Abs(sum.G_Val);
                        sum.B_Val = Math.Abs(sum.B_Val);
                        data[i, j] = sum;
                    }
                    else if (Postprocessing == "None")
                    {
                        result[i, j] = Color.FromArgb((int)sum.R_Val, (int)sum.G_Val, (int)sum.B_Val);
                    }
                }
            }
            if (Postprocessing == "Absolute")
            {
                result = pixel.Contrast(0, 255, data);
            }
            return result;
        }
    }
}