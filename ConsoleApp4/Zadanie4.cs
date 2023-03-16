using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz przykladowe zdanie: ");
            string kod = Console.ReadLine();
            int i = kod.Length - 1;
            string odwracanie = "";
            do
            {
                odwracanie += kod[i];
                i--;
            }
            while (i > 0);
            Console.WriteLine("Ciąg znaków w odrotnej kolejnosści: " + odwracanie);
        }
    }
}
