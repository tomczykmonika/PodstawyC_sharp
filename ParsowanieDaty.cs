using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_
{
    internal class ParsowanieDaty
    {
        /* Zadanie:
         * Utwórz aplikację konsolową która pobierze od użytkownika datę jego urodzin 
         * i na tej podstawie obliczy ile mięło dni od tej daty do obecnego dnia.
         */

        public static void ParsDateCwiczenie()
        {   /*
            Console.WriteLine("Podaj rok urodzenia");
            int rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj miesiąc urodzenia");
            int miesiac = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dzień urodzenia");
            int dzien = int.Parse(Console.ReadLine());
            DateTime dataUrodzenia = new DateTime(rok, miesiac, dzien);
            */

            Console.WriteLine("Podaj datę urodzenia (rrrr-mm-dd)");
            DateTime dataUrodzenia = DateTime.Parse(Console.ReadLine());
            TimeSpan timeSpan = DateTime.Now - dataUrodzenia;

            Console.WriteLine($"Urodziłeś się {(int)timeSpan.TotalDays} dni temu.");

        }


    }
}
