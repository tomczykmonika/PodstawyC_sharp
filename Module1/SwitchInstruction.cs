using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module1
{
    internal class SwitchInstruction
    {
        public static double CalculateParkingFee(int hours)
        {
            /* Opis: 
             * Twoim zadaniem jest napisanie kalkulatora opłat za parkowanie w zależności od czasu postoju na parkingu. 
             * Kalkulator powinien uwzględniać następujący schemat opłat:
             * Pierwsza godzina: 5 zł
             * Każda kolejna rozpoczęta godzina: 3 zł
             */
            double result = 0;
            // TODO: Uzupełnij implementację kalkulatora opłat za parkowanie
            switch (hours > 1)
            {
                case false:
                    result = 5;
                    break;
                default:
                    result = 5 + (hours - 1) * 3;
                    break;
            }

            return result;
        }

        public static void Switch_cwiczenia()
        {
            Console.WriteLine("Instrukcja Switch");
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday :(");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of week work");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
            //cwiczenie dla SWITCH
            double cash = CalculateParkingFee(1);
            Console.WriteLine(cash);
            cash = CalculateParkingFee(2);
            Console.WriteLine(cash);
            cash = CalculateParkingFee(3);
            Console.WriteLine(cash);
        }
    }
}
