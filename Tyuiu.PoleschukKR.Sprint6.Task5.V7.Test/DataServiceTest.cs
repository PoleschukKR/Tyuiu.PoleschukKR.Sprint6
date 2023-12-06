using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint6.Task5.V7.Lib;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
             
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint6\Tyuiu.PoleschukKR.Sprint6.Task5.V7\bin\Debug\InPutFileTask5V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);



        }
    }
}
