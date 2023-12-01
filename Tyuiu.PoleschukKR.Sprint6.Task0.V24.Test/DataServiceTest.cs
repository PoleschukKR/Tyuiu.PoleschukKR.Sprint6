using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task0.V24.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 1024;
            Assert.AreEqual(wait, res);
        }
    }
}
