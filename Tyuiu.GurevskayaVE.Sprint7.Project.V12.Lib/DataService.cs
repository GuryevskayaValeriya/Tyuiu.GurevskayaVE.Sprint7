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
        
        public double SredOZU(string[,] path)
        {
            double sum = 0;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                sum += Convert.ToDouble(path[i, 4]);
            }
            double average = sum / (path.GetLength(0) - 1);
            return Math.Round(average, 2);
        }

        public double MaxYadra(string[,] path)
        {
            double max = 0;
            int columnIndex = 3; 
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) > max) 
                {
                    max = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return max;
        }

    }
}