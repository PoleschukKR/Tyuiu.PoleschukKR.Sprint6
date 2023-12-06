using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PoleschukKR.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] array = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x;
                y = Math.Round(y, 2);
                if (2 - x == 0)
                {
                    y = 0;
                }
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}
