using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_
{
    internal class cwiczenieIterowanie
    {
        public static void iteracja()
        {
            int sum = 0;
            int? max = null;
            int value;
            do
            {
                Console.Write("Wprowadź wartość: ");
                value = int.Parse(Console.ReadLine());
                sum += value;
                if (max == null || max < value)
                {
                    max = value;
                }
            } while (value != 0);
            Console.WriteLine($"Podałeś zero! Suma wynosi {sum}");

            if (max != null)
            {
                Console.WriteLine($"Maksymalna podana wartość: {max}");
            }
            else
            {
                Console.WriteLine("Nie wprowadzono wartości.");
            }

        }
    }
}
