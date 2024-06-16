using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module1
{
    internal class IfElseStatment
    {
        public static string CalculateGrade(double percentage)
        {
            /* Opis: 
             * Twoim zadaniem jest napisać prosty kalkulator oceny, który na podstawie podanej procentowej oceny z testu będzie zwracał odpowiadającą jej literową ocenę. 
             * Kalkulator powinien uwzględniać następujący schemat oceniania:
             * Ocena A: od 90%
             * Ocena B: od 80%
             * Ocena C: od 70%
             * Ocena D: od 60%
             * Ocena F: poniżej 60%
             */
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public static void IF_cwiczenia()
        {
            Console.WriteLine("TRÓJSKŁADNIKOWY OPERATOR WARUNKOWY - czyli skrócony IF");
            Console.WriteLine("warunek logiczny ? true : false");
            int x = 5;
            int y = 10;
            int greaterNumber = x > y ? x : y;
            Console.WriteLine("x = 5, y = 10");
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);

            //instrukcja else if
            Console.WriteLine("Instrukcja IF-ELSE");
            Console.WriteLine("Podaj rok urodzenia:");
            string userInput = Console.ReadLine();
            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Year - yearOfBirth > 18;

            if (isUserOver18)
            {
                Console.WriteLine("Hello");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oh well its Sunday!");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
            Console.WriteLine("Bye");

            //cwiczenie dla If
            string grade = CalculateGrade(90);
            Console.WriteLine(grade);
            grade = CalculateGrade(89);
            Console.WriteLine(grade);
            grade = CalculateGrade(75);
            Console.WriteLine(grade);
            grade = CalculateGrade(69);
            Console.WriteLine(grade);
            grade = CalculateGrade(44);
            Console.WriteLine(grade);
        }
    }
}
