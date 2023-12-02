using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task2.V27.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task2.V27.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);
            int len = (stopValue - startValue) + 1;
            double[] wait = {-27.22, -22.25, -16.66, -11.04, -6.13, -3, 4.84, 8.86, 14.43, 20.18, 25.24};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
