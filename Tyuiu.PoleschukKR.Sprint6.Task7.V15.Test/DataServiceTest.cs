using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task7.V15.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint6\Tyuiu.PoleschukKR.Sprint6.Task7.V15\bin\Release\InPutFileTask7V15.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait = {
                { -18, 0, -9, -10, -18, -17, -19, 20, 14, -16 },
                { -10, -17, 6, -7, -20, 17, -13, 15, -4, -18 },
                { -11, -12, -20, -20, 10, -13, -15, 11, 14, 16 },
                { 18, 4, -20, 7, -8, 6, -11, 3, 7, -2 },
                { -14, -15, -12, 16, -12, 19, 12, -10, -4, 13 },
                { 4, -6, -11, 3, 13, 1, -20, 13, -5, 13 },
                { 9, -4, -17, 19, 5, 5, -1, -17, -4,  9 },
                { -20, -9, -15, 19, 17, 10, -7, 3, 5, 15 },
                { -16, -5, 20, -16, 19, 0, 3, 12, -17, 2 },
                { -20, 8, -2, 8, 12, 12, -8, 0, 1, 19 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
