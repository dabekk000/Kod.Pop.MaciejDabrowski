using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie3
    {
        static void Main(string[] args)
        {

            string kod;
            int dlugosc = 0;
            Console.WriteLine("Podaj przykładowe zdanie");
            kod = Console.ReadLine();
            while (dlugosc < kod.Length)
            {
                dlugosc++;
            }
            Console.WriteLine("Dlugość znaków w tym zdaniu to \"{0}\" wynosi: {1}", kod, dlugosc);
        }
    }
}
