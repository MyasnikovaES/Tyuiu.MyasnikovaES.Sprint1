using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MyasnikovaES.Sprint1.Task3.V0.Lib;

namespace Tyuiu.MyasnikovaES.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;

            double wait = 12;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
