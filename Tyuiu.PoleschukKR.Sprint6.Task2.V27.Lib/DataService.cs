using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PoleschukKR.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2*x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x);
                double z = Math.Cos(x) - 2 * x;
                if (z == 0)
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
