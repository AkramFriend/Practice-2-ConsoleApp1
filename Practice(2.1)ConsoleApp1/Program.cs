using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2._1_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sumOfPoints = "s";
            int s = 64 + 54 + 0;
            string averagePoint = "n";
            double n = (double)s / 3;
            Console.WriteLine($"Сумма баллов по всем предметам: {s} \n Средний балл: {n}");
            Console.ReadKey();
        }
    }
}
