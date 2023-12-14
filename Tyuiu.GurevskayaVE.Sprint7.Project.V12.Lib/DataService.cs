using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public static double SredOZU(string[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            double cnt = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cnt += Convert.ToDouble(matrix[i, 4]); 
                    
                }
            }

            return Math.Round(cnt/rows);
        }

    }
}
