using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    /* yield
     * Opis: 
     * Twoim zadaniem jest napisanie programu, który będzie generował kolejne liczby parzyste. 
     * Użyj konstrukcji yield do generowania tych liczb.
     * 
     * Wymagania:
     * - Zaimplemenuj klasę EvenNumberGenerator zawierającą metodę GenerateEvenNumbers, 
     * która będzie generować kolejne liczby parzyste.
     * - Użyj konstrukcji yield w metodzie GenerateEvenNumbers do generowania liczb parzystych.
     */
    public class EvenNumberGenerator
    {
        public static IEnumerable<int> GenerateEvenNumbers()
        {
            // TODO: Uzupełnij implementację metody GenerateEvenNumbers, używając konstrukcji yield,
            // aby generować kolejne liczby parzyste.
            for (int i = 0; i < 1000; i += 2)
            {
                yield return i;
            }
        }
        public static void EvenNumberExample()
        {
            var evenNumbers = GenerateEvenNumbers();
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
