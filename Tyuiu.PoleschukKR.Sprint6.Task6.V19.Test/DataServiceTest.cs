using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task6.V19.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Sprint6\InPutFileTask6V19.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "HqrXl PAlR TwlB AWkgYPxilmC ";

            Assert.AreEqual(wait, res);
        }
    }
}
