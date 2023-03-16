using System;
//zadanie 1 wersja trudniejsza
//class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Podaj a");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Podaj b");
//        int b = Convert.ToInt32(Console.ReadLine());
//        while (a <= b)
//        {
//            if (a%2==0)
//            {
//                Console.WriteLine(a);
//            }
//            a++;
//        }
//    }
//}

//zadanie 1 wersja zwykla
//class program
//{
//    static void Main(string[] args)
//    {
//        int a;
//        int suma = 0;
//        Console.WriteLine("Podaj liczbe całkowitą wiekszą od 0: ");
//        a = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= a; i++)
//        {
//            suma += i;
//        }
//        Console.WriteLine("Suma liczb od 1 do {0} wynosi: {1}", a, suma);
//    }
//}

//zadanie 2
//class program
//{
//    static void Main(string[] args)
//    {
//        string haslo;
//        string hasloUzytkownika = "uzytkownik12345";
//        Console.WriteLine("Podaj hasło:");
//        haslo = Console.ReadLine();
//        if (haslo == hasloUzytkownika)
//        {
//            Console.WriteLine("Hasło jest poprawne");
//        }
//        else if (haslo != hasloUzytkownika){ 
//            Console.WriteLine("Hasło jest nie poprawne");
//        }
//    }
//}





//zadanie 3
//class program
//{
//    static void Main(string[] args)
//    {

//        string kod;
//        int dlugosc = 0;
//        Console.WriteLine("Podaj przykładowe zdanie");
//        kod = Console.ReadLine();
//        while (dlugosc < kod.Length)
//        {
//            dlugosc++;
//        }
//        Console.WriteLine("Dlugość znaków w tym zdaniu to \"{0}\" wynosi: {1}", kod,dlugosc);

//    }
//}

// zadanie 4
//class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Wpisz przykladowe zdanie: ");
//        string kod = Console.ReadLine();
//        int i = kod.Length - 1;
//        string odwracanie = "";
//        do
//        {
//            odwracanie += kod[i];
//            i--;
//        }
//        while (i > 0);
//        Console.WriteLine("Ciąg znaków w odrotnej kolejnosści: "+ odwracanie);
//    }
//}
//zadanie 5 [trudne]
class program
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