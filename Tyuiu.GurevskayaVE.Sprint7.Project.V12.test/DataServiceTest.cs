using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint7.Project.V12.Lib;

namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12.test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void Check()
        {
            string path = @"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint7\Tyuiu.GurevskayaVE.Sprint7.Project.V12\bin\Debug\OutPutIVM.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);

        }
    }
}
