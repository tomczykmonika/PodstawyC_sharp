using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module1
{
    internal class TablicePetle
    {   /*Twoim zadaniem jest napisanie programu do analizy temperatur. 
         * Program ma przechowywać dane o temperaturach przez kilka dni i wykonywać na nich operacje statystyczne.
         * Parametr int[] temperatures przechowuje tablice odnotowanych temperatur
         */

        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            int maxTemp = temperatures[0];
            foreach (int temperature in temperatures)
            {
                if (maxTemp < temperature)
                {
                    maxTemp = temperature;
                };
            }
            return maxTemp;
        }

        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            int minTemp = temperatures[0];
            foreach (int temperature in temperatures)
            {
                if (minTemp > temperature)
                {
                    minTemp = temperature;
                };
            }
            return minTemp;
        }
        public static void TabPetPrzyklady()
        {
            // TABLICE i PĘTLE
            // Tablice mają stałą długość.
            // Tablice są indeksowane od 0.
            string[] cars = { "Volvo", "BMW", "Mazda" };
            Console.WriteLine(cars[0]);
            cars[2] = "Tesla";
            Console.WriteLine(cars[2]);
            int i = 0;


            // pętla WHILE - najpierw sprawdzenie warunku, potem blok kodu
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                //Przykład wcześniejszego wyjścia z pętli:
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                };
                i++;
            }

            // pętla DO WHILE - najpierw blok kodu, potem sprawdzenie warunku
            Console.WriteLine("To exit, type 'x'");
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");

            //pętla FOR
            cars[2] = "Mazda";
            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
                if (cars[j] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            //pętla FOREACH
            foreach (string car in cars)
            {
                Console.WriteLine(car);
                if (car == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            //cwiczenia
            int[] temperature = { 5, 10, 15, 20, 1, -5, 3 };
            int temperatureMAX = FindHighestTemperature(temperature);
            int temperatureMIN = FindLowestTemperature(temperature);
            Console.WriteLine($"MAX: {temperatureMAX} MIN: {temperatureMIN}");

        }
    }
}
