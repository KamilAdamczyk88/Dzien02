using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03Pliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dublujemy każdy \
            Console.WriteLine("Wersja pierwsza:");
            string dane = File.ReadAllText("C:\\Users\\kurs\\source\\repos\\Dzien02\\P03Pliki\\dane_do_odczytu.txt");
            Console.WriteLine(dane);

            //wersja druga
            Console.WriteLine("Wersja druga:");
            string dane2 = File.ReadAllText("..\\..\\dane_do_odczytu.txt");
            Console.WriteLine(dane2);

            //wersja trzecia
            //@ nie interpretuj
            Console.WriteLine("Wersja trzecia:");
            string dane3 = File.ReadAllText(@"..\..\dane_do_odczytu.txt");
            Console.WriteLine(dane3);

            //wersja trzecia
            //kopiowanie plikow
            Console.WriteLine("Wersja czwarta kopiowanie:");
            string dane4 = File.ReadAllText("dane_do_odczytu.txt");
            Console.WriteLine(dane4);

            //gdzie jestem?
            //druga czesc:str 34

            //czytanie z sieci WWW
            Console.WriteLine("Wersja piąta WWW:");
            string sieci = new WebClient().DownloadString("http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt");
            Console.WriteLine(sieci);
            Console.ReadKey();
        }
    }
}
