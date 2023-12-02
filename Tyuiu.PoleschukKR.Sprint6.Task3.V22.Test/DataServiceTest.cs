using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task3.V22.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            
            int[,] matrix = new int[,] { {17,0,19,-8,-1},
                                         {9, 4, -5, 7,15},
                                         {11,13,4,-4,-14},
                                         {11,14,5,-15,16},
                                         {2,-14,-2,11,11}};

            int[,] waitMatrix = { {17,0,19,0,-1},
                                  {9, 4, -5, 7,15},
                                  {11,13,4,-4,-14},
                                  {11,14,5,-15,16},
                                  {2,-14,-2,11,11}};

            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(waitMatrix, res);


        }
    }
}
