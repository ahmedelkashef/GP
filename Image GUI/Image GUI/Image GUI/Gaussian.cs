using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhotoEditor
{
    class Gaussian
    {
        public double[,] CalculateGaussianKernel(double sigma, int Size)
        {
            double[,] temp = new double[Size, Size];
            int x = Size / 2;
            double num = 1.0 / (2.0 * Math.PI * sigma * sigma);
            for (int i = -x; i < x; i++)
            {
                for (int j = -x; j < x; j++)
                {
                    double expo = Math.Exp(-((i * i) + (j * j)) / (2.0 * sigma * sigma));
                    temp[i + x, j + x] = num * expo;
                }
            }
            return temp;
        }

        public double[,] CalculateGaussianKernel(double sigma)
        {
            int n = (int)(sigma * 3.7 - 0.5);
            int size = n * 2 + 1;
            return CalculateGaussianKernel(sigma, size);
        }

        public double[,] CalculateNormalizedkernal(double sigma)
        {
            return NormalizeMatrix(CalculateGaussianKernel(sigma));
        }

        public double[,] NormalizeMatrix(double[,] matrix)
        {
            double[,] ret = new double[matrix.GetLength(0), matrix.GetLength(1)];
            double sum = 0;
            for (int i = 0; i < ret.GetLength(0); i++)
            {
                for (int j = 0; j < ret.GetLength(1); j++)
                    sum += matrix[i, j];
            }
            if (sum != 0)
            {
                for (int i = 0; i < ret.GetLength(0); i++)
                {
                    for (int j = 0; j < ret.GetLength(1); j++)
                        ret[i, j] = matrix[i, j] / sum;
                }
            }
            return ret;
        }
    }
}

