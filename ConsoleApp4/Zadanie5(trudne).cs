using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie5_trudne_
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbe naturalną a");
            a = Convert.ToInt32(Console.ReadLine());
            bool[] sprawdz = new bool[a + 1];
            for (int i = 2; i <= a; i++)
            {
                sprawdz[i] = true;
            }
            for (int i = 2; i <= a; i++)
            {
                if (sprawdz[i])
                {
                    for (int b = i * 2; b <= a; b += i)
                    {
                        sprawdz[b] = false;
                    }
                }
            }
            Console.WriteLine("Liczby pierwsze do a: ");
            for (int i = 0; i <= a; i++)
            {
                if (sprawdz[i])
                {
                    Console.WriteLine(i + " jest liczbą pierwszą");
                }
            }
            Console.ReadKey();
        }
    }
}
