using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PoleschukKR.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
