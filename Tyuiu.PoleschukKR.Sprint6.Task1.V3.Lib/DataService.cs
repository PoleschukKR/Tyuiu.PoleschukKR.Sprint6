using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PoleschukKR.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            { 
                y = 5 - 3 * i+ (1 + Math.Sin(i)) / (2 * i - 0.5);
                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
