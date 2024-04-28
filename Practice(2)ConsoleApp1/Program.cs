using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Акрам Шоев Саидасрорович";
            sbyte age = 18;
            string email = "shoevakramchik@gmail.com";
            float pointsForProgramming = 54.0f;
            double pointsForMathematics = 64.0;
            short pointForPhisics = 0;
            Console.WriteLine($"Ф.И.О: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программирования: {pointsForProgramming} \nБаллы по математике: {pointsForMathematics} \nБаллы по физике: {pointForPhisics}");
            Console.ReadKey();
            
        }
    }
}
