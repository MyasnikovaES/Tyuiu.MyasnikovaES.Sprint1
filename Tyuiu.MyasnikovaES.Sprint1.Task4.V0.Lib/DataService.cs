using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MyasnikovaES.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            return Math.Sqrt(Math.Abs(x + y)) / Math.Abs(3 - x);
        }
    }
}
