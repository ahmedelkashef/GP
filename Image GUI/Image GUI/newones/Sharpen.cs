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

namespace PhotoEditor_2015
{
    class Sharpen
    {
        NeighborOperations Filter = new NeighborOperations();

        public Color[,] laplacian(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Color[,] Tmp_Buffer;
            double[,] Mask = new double[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
            Tmp_Buffer = Filter.LinearFilter(Org_Buffer, Mask, OriginX, OriginY, "Cutoff");
            return Tmp_Buffer;
        }

        public Color[,] SobelHorizontal(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Color[,] Tmp_Buffer;
            double[,] Mask = new double[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            Tmp_Buffer = Filter.LinearFilter(Org_Buffer, Mask, OriginX, OriginY, "Absolute");
            return Tmp_Buffer;
        }

        public Color[,] SobelVertical(Color[,] Org_Buffer, int OriginX, int OriginY)
        {
            Color[,] Tmp_Buffer;
            double[,] Mask = new double[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            Tmp_Buffer = Filter.LinearFilter(Org_Buffer, Mask, OriginX, OriginY, "Absolute");
            return Tmp_Buffer;
        }

        public Color[,] Magintude(Color[,] Hor_Buffer, Color[,] Ver_Buffer)
        {
            int Width = Hor_Buffer.GetLength(0);
            int Height = Hor_Buffer.GetLength(1);
            Color[,] Magintude_Buffer = new Color[Width, Height];
            Data data;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    data.R_Val = Math.Abs(double.Parse(Hor_Buffer[i, j].R.ToString()) + double.Parse(Ver_Buffer[i, j].R.ToString()));
                    data.G_Val = Math.Abs(double.Parse(Hor_Buffer[i, j].G.ToString()) + double.Parse(Ver_Buffer[i, j].G.ToString()));
                    data.B_Val = Math.Abs(double.Parse(Hor_Buffer[i, j].B.ToString()) + double.Parse(Ver_Buffer[i, j].B.ToString()));

                    data.R_Val = Filter.pixel.cutOff(data.R_Val);
                    data.G_Val = Filter.pixel.cutOff(data.G_Val); 
                    data.B_Val = Filter.pixel.cutOff(data.B_Val);

                    Magintude_Buffer[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                }
            }
            return Magintude_Buffer;
        }

    }
}
