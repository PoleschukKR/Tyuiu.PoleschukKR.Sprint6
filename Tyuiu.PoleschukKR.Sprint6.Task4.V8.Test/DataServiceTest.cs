using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task4.V8.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] wait = new double[len];
            wait[0] = -8.86;
            wait[1] = -7.19;
            wait[2] = -6.14;
            wait[3] = -4.76;
            wait[4] = -2.33;
            wait[5] = 1;
            wait[6] = 4.38;
            wait[7] = 0;
            wait[8] = 6.13;
            wait[9] = 7.07;
            wait[10] = 8.61;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
