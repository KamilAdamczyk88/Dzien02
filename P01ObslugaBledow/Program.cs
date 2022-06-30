using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //błedy kompilacji
            int a = 0;
            int b = 10;

            try
            {
                Console.WriteLine("przed bledem");
                b = 10 / a;
                Console.WriteLine("po bledzie");
            }
            //catch (Exception)
            //{
            //    Console.WriteLine("Złapany wyjątek");
            //    b = 123;
                
            //    // throw;
            //}
            catch (DivideByZeroException)
            {
                Console.WriteLine("Złapany wyjątek dzieleni przez zero");
                b = 123;
            }
            catch(FormatException)
            {
                Console.WriteLine("Złapany wyjątek dzieleni przez zero");
                b = 456;
            }

            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Złapany wyjątek poza zakresem");
                b = 789;
            }
            catch (Exception)
            {
                Console.WriteLine("Zapisz w logach");
                throw;
            }

            Console.WriteLine($"Dalsza czesc programu: {b}");

            //blady czasu wykonanie- runtime
            //bledy wyjatkowe brak polaczenia, dzielenie przez zero, brak pliku na dysku
            //bledy ciche - bledy w algorytmie (testy jednostkowe)


            Console.ReadKey();
        }
    }
}
