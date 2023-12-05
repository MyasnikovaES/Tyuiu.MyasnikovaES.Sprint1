using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MyasnikovaES.Sprint1.Task4.V0.Lib;

namespace Tyuiu.MyasnikovaES.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 / Выполнила: Мясникова Е. С. / ИСПБ-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема:  Class Math                                                        *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнила: Мясникова Елена Сергеевна / ИСПБ-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение Х : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("sqrt{|x + y|} / {|3 - x|} = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
