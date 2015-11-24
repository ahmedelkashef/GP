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

namespace PhotoEditor_2015
{
    class GeometryOperations
    {
        private Boolean flag_rotate_shear = false;
        public Boolean flag_interpolate = false;
        PixelOperations pixel = new PixelOperations();

        private Color[,] Transform(Color[,] Org_Buffer, Matrix m)
        {
            int width = Org_Buffer.GetLength(0);
            int height = Org_Buffer.GetLength(1);

            PointF[] p = new PointF[] {
            new PointF(0,0),
            new PointF(width,0),
            new PointF(0,height),
            new PointF(width,height)};

            m.TransformPoints(p);
            float minx = 9999999, miny = 9999999;
            float maxx = 0, maxy = 0;
            getMinMax(p, out minx,out maxx,out miny,out maxy);

            float newWidth = maxx - minx;
            float newHeight = maxy - miny;

            if (flag_rotate_shear)
                m.Translate(-minx, -miny, MatrixOrder.Append);
            if (m.IsInvertible)
                m.Invert();

            Color[,] c = new Color[(int)Math.Ceiling(newWidth), (int)Math.Ceiling(newHeight)];
            PointF[] pnt = new PointF[1];
            Bitmap res = new Bitmap((int)Math.Ceiling(newWidth), (int)Math.Ceiling(newHeight));

            for (int i = 0; i < (int)newWidth; i++)
            {
                for (int j = 0; j < (int)newHeight; j++)
                {
                    pnt[0].X = i;
                    pnt[0].Y = j;
                    m.TransformPoints(pnt);
                    Data data;
                    if (pnt[0].X < width && pnt[0].Y < height && pnt[0].X >= 0 && pnt[0].Y >= 0)
                    {
                        if (!flag_interpolate)
                        {
                            data.R_Val = Org_Buffer[(int)(pnt[0].X), (int)(pnt[0].Y)].R;
                            data.G_Val = Org_Buffer[(int)(pnt[0].X), (int)(pnt[0].Y)].G;
                            data.B_Val = Org_Buffer[(int)(pnt[0].X), (int)(pnt[0].Y)].B;
                            c[i, j] = Color.FromArgb((int)data.R_Val, (int)data.G_Val, (int)data.B_Val);
                        }
                        else
                            c[i, j] = interpolation(Org_Buffer, pnt[0]);
                    }
                }
            }
            flag_rotate_shear = false;
            return c;
        }

        private void getMinMax(PointF[] p, out float MinX, out float MaxX, out float MinY, out float MaxY)
        {
            MinX = 99999999;
            MinY = 99999999;
            MaxX = 0;
            MaxY = 0;
            for (int i = 0; i < 4; i++)
            {
                if (MinX > p[i].X)
                    MinX = p[i].X;
                if (MinY > p[i].Y)
                    MinY = p[i].Y;
                if (MaxX < p[i].X)
                    MaxX = p[i].X;
                if (MaxY < p[i].Y)
                    MaxY = p[i].Y;
            }
        }

        public Color[,] scale(Color[,] Org_Buffer, float sX, float sY)
        {
            Matrix M = new Matrix();
            M.Scale(sX, sY);
            return Transform(Org_Buffer, M);
        }

        public Color[,] rotate(Color[,] Org_Buffer, int angle)
        {
            flag_rotate_shear = true;
            Matrix M = new Matrix();
            M.Rotate(angle);
            return Transform(Org_Buffer, M);
        }

        public Color[,] shear(Color[,] Org_Buffer, float sx, float sy)
        {
            flag_rotate_shear = true;
            Matrix M = new Matrix();
            M.Shear((float)sx, (float)sy);
            return Transform(Org_Buffer, M);
        }

        public Color interpolation(Color[,] original_Buffer, PointF p)
        {
            int x1 = (int)Math.Floor(p.X),
                y1 = (int)Math.Floor(p.Y),
                x2 = x1 + 1,
                y2 = y1 + 1;

            x1 = OutBoundery(x1, original_Buffer.GetLength(0));
            x2 = OutBoundery(x2, original_Buffer.GetLength(0));
            y1 = OutBoundery(y1, original_Buffer.GetLength(1));
            y2 = OutBoundery(y2, original_Buffer.GetLength(1));

            Color p1 = original_Buffer[x1, y1];
            Color p2 = original_Buffer[x2, y1];
            Color p3 = original_Buffer[x1, y2];
            Color p4 = original_Buffer[x2, y2];

            double Xfraction = p.X - x1;
            double Yfraction = p.Y - y1;

            //interpolate in X_Direction
            Data dataX1, dataX2, dataFinal;
            dataX1 = interpolate(p1, p2, Xfraction);
            dataX2 = interpolate(p3, p4, Xfraction);
            //interpolate in Y_Direction
            Color newX1 = Color.FromArgb((int)dataX1.R_Val, (int)dataX1.G_Val, (int)dataX1.B_Val);
            Color newX2 = Color.FromArgb((int)dataX2.R_Val, (int)dataX2.G_Val, (int)dataX2.B_Val);
            dataFinal = interpolate(newX1, newX2, Yfraction);

            return Color.FromArgb((int)(dataFinal.R_Val), (int)(dataFinal.G_Val), (int)(dataFinal.B_Val));
        }

        private Data interpolate(Color C1, Color C2, double frac)
        {
            Data data;
            data.R_Val = C1.R * (1 - frac) + C2.R * frac;
            data.G_Val = C1.G * (1 - frac) + C2.G * frac;
            data.B_Val = C1.B * (1 - frac) + C2.B * frac;
            return data;
        }

        private int OutBoundery(int Val, int Boundry)
        {
            if (Val >= Boundry)
                return Boundry - 1;
            return Val;
        }
    }
}
