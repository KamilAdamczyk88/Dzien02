using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02KalkulatorOdpornynaUzyszkodnika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal liczba1 = 0;
            decimal liczba2 = 0;
            decimal wynik = 0;
            int error = 0;
            CultureInfo unvC = CultureInfo.InvariantCulture; //uniwersalny typ
            CultureInfo unvD = new CultureInfo("Pl-PL"); 
            while (true)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwsza liczbe:");
                        liczba1 = Convert.ToDecimal(Console.ReadLine(), unvD);
                        error = 0;
                    }
                    catch (Exception)
                    {
                        error = 1;
                        Console.WriteLine("Nie poprawna liczba");

                    }
                } while (error == 1);

                do
                {
                    try
                    {
                        Console.WriteLine("Podaj druga liczbe:");
                        liczba2 = Convert.ToDecimal(Console.ReadLine(), unvD);
                        error = 0;
                    }
                    catch (Exception)
                    {
                        error = 1;
                        Console.WriteLine("Nie poprawna liczba");

                    }
                } while (error == 1);
                try
                {
                    wynik = liczba1 / liczba2;
                    Console.WriteLine($"Twoj wynik to: {wynik}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ogolny blad");
                    
                    //throw;
                }
                Console.WriteLine("Czy chcesz kontynuować? T/N");
                char kont;
                kont = Console.ReadKey().KeyChar;
                if (kont == 'T' | kont == 't')
                {
                    Console.Clear();
                    continue;
                    
                }
                else
                {
                    break;
                    
                }

            }
            
               
            
            
            
            
            Console.ReadKey();
        }
    }
}
