using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie1Trudne
    {
        static void Main(string[] args)
        {
            int a;
            int suma = 0;
            Console.WriteLine("Podaj liczbe całkowitą wiekszą od 0: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma liczb od 1 do {0} wynosi: {1}", a, suma);
        }
    }
}
