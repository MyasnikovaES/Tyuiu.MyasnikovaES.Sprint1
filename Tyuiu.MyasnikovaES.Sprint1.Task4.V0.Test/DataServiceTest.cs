using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MyasnikovaES.Sprint1.Task4.V0.Lib;
    
namespace Tyuiu.MyasnikovaES.Sprint1.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
