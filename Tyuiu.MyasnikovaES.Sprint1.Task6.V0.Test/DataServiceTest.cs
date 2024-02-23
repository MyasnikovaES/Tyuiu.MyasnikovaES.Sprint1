using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MyasnikovaES.Sprint1.Task6.V0.Lib;


namespace Tyuiu.MyasnikovaES.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "123";
        }
    }
}
