using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module1
{
    public class enumCwiczenia()
    {
        enum Gender : byte
        {
            Male = 1,
            Female = 2
        }
        public static void GenderCwiczenie()
        {
            // ENUM
            Console.WriteLine("What is your gender? 1 - Male, 2 - Female");
            string userInput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Only women are allowed");
            }
            else
            {
                Console.WriteLine("Hi!");
            }

        }
    }
}
