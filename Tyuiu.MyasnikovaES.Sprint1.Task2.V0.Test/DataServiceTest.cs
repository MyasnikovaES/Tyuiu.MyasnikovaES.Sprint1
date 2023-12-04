using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MyasnikovaES.Sprint1.Task2.V0.Lib;

namespace Tyuiu.MyasnikovaES.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquare(x);
            Assert.AreEqual(4, res);



        }
    }
}
