using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

            string[,] array = { {"Apple MacBook Air 13 M1", "Apple", "Apple M1", "8", "8", "13,3", "2020" },
{ "Lenovo IdeaPad Gaming 3","Lenovo","Intel Core i5 12450H","8","16","16","2022" },
{ "Thunderobot 911 Air X","Thunderobot","Intel Core i5 12450H","8","16","15,6","2022" },
{ "ASUS M1502IA","ASUS","AMD Ryzen 7 4800H","8","16","15,6","2021" },
{ "HONOR MagicBook X 16","HONOR","Intel Core i5 12450H","8","8","16","2022" },
{ "Irbis NB265","Irbis","Intel Celeron N4020","2","4","14,1","2016" },
{ "Apple MacBook Pro 14","Apple","Apple M3 Pro","11","18","14,2","2021" },
{ "HUAWEI Matebook D 15 i5","HUAWEI","Intel Core i5","4","8","15,6","2021" },
{ "MSI Katana GF76"," MSI","Intel Core i5 11260H","6","8","17,3","2021" } };
            
        }
    }
}
