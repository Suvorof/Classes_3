using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class Program
    {
        static void Main()
        {
            Figure multycorner = new Figure("многоугольник");
            Console.WriteLine(multycorner.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
