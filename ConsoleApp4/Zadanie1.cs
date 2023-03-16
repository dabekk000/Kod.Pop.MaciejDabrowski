using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a <= b)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
             a++;
            }
        }
    }
}
