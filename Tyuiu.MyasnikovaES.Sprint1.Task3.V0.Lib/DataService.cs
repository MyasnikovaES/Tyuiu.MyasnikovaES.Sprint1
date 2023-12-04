using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MyasnikovaES.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V12


    {
        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            return lengthCathetus1 * lengthCathetus2 / 2;
        }
    }
}
