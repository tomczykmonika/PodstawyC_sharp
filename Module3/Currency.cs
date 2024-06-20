using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    /* Słowniki, a listy
     */
    internal class Currency
    {
        public Currency(string name, string fullName, double rate)
        {
            Name = name;
            FullName = fullName;
            Rate = rate;
        }

        public string Name { get; set; }
        public string FullName { get; set; }
        public double Rate { get; set; }

        static List<Currency> GetCurrenciesLista()
        {
            return new List<Currency>
            {
                new Currency("usd","United States, Dollar",1),
                new Currency("eur", "Euro",0.83975),
                new Currency("gbp", "British Pound",0.78487),
                new Currency("cad", "Canadian Dollar",1.35487),
                new Currency("inr", "Indian Rupee",73.04),
                new Currency("mxn", "Mexcian Peso",21.7571),
            };
        }
        static Dictionary<string, Currency> GetCurrenciesSlownik()
        {
            return new Dictionary<string, Currency>
            {
                {"usd", new Currency("usd","United States, Dollar",1) },
                {"eur", new Currency("eur", "Euro",0.83975)},
                {"gbp", new Currency("gbp", "British Pound",0.78487)},
                {"cad", new Currency("cad", "Canadian Dollar",1.35487)},
                {"inr", new Currency("inr", "Indian Rupee",73.04)},
                {"mxn", new Currency("mxn", "Mexcian Peso",21.7571)},
            };
        }
        public static void CurrencyExample()
        {
            /*
            //Waluty jako Lista
            List<Currency> currencies = GetCurrenciesLista();
            Console.WriteLine("Check the rate for: ");
            string userInput = Console.ReadLine();

            Currency selectedCurrency = currencies.FirstOrDefault(c => c.Name == userInput);
            if (selectedCurrency != null)
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found.");
            }
            */

            //Waluty jako Słownik
            Dictionary<string, Currency> currencies = GetCurrenciesSlownik();
            Console.WriteLine("Check the rate for: ");
            string userInput = Console.ReadLine();

            Currency selectedCurrency = null;
            // Każdy słownik posiada metodę TryGetValue, która umożliwia sprawdzenie
            // czy user podał wartość istniejącą w słowniku.
            if (currencies.TryGetValue(userInput, out selectedCurrency))
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }
            //usuwanie i dodawania do słownika
            currencies.Remove("usd");
            currencies.TryAdd("usd", new Currency("usd", "United States, Dollar", 1));
            //TryAdd sprawdza czy nie istenieje już taki klucz w słowniku
            //jest bezpieczeniejsza od Add
        }
    }
}
