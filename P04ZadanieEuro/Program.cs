using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace P04ZadanieEuro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = "";
            var waluta = "";
            
            CultureInfo unvC = CultureInfo.InvariantCulture;
            //var date = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                Console.WriteLine("Wybierz Walutę: USD/EUR/PLN");
                 waluta = Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Nie poprawny format waluty!");
                
            }
            try
            {
                Console.WriteLine("Podaj date w formacie: RRRR-MM-DD");
                 date = Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Nie poprawny format daty!");
                
            }

            try
            {
                string euro = new WebClient().DownloadString("http://api.nbp.pl/api/exchangerates/rates/A/" + waluta + "/" + date);
                var jsonString = JsonDocument.Parse(euro);
                double wartosc = Convert.ToDouble(jsonString.RootElement.GetProperty("rates")[0].GetProperty("mid").ToString(), unvC);
                Console.WriteLine($"Kurs Euro na dzień {date} jest następujący:");
                Console.WriteLine(wartosc);
            }
            catch (Exception)
            {

                Console.WriteLine("Błąd Użytkowniku!");
            }

            


            
            Console.ReadLine();

        }
    }
}
