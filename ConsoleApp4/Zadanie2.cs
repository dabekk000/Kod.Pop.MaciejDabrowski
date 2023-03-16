using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Zadanie2
    {
        static void Main(string[] args)
        {
            string haslo;
            string hasloUzytkownika = "uzytkownik12345";
            Console.WriteLine("Podaj hasło:");
            haslo = Console.ReadLine();
            if (haslo == hasloUzytkownika)
            {
                Console.WriteLine("Hasło jest poprawne");
            }
            else if (haslo != hasloUzytkownika)
            {
                Console.WriteLine("Hasło jest nie poprawne");
            }
        }
    }
}
