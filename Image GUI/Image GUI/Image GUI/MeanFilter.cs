using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class MeanFilter
    {
        public double[,] CalculateMeanFilter(int mask_width, int mask_height)
        {
            double[,] mask = new double[mask_width, mask_height];
            for (int i = 0; i < mask_width; i++)
            {
                for (int j = 0; j < mask_height; j++)
                {
                    mask[i, j] = (double)1 / (mask_width * mask_height);
                }
            }
            return mask;
        }
    }
}
