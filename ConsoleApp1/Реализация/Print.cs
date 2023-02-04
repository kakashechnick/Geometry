using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Printer
    {
        public static void print(Geometry figure)
        {
            Console.WriteLine(figure.GetType().Name);
            figure.prient();
        }
    }
}
