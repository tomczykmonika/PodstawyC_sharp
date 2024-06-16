using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PodstawyC_
{
    internal class Podstawy
    {
        public static void WriteAndRead()
        {

            Console.WriteLine("*** Różnica między Write, a WriteLine ***");
            Console.Write("Hello, ");
            Console.Write("World!");

            Console.WriteLine("Hello, ");
            Console.WriteLine("World!");
            Console.WriteLine();

            Console.WriteLine("*** Przekazywanie informacji do Consoli ***");
            Console.WriteLine("Type in your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, ");
            Console.WriteLine(name);
        }

        public static void TypyZmiennych()
        {
            //Typy zmiennych w C# predefiniowane
            string someText = "Some text";
            Console.WriteLine(someText);
            char jChar = 'j';
            Console.WriteLine(jChar);
            char jCharUnicode = '\u006A';
            Console.WriteLine(jCharUnicode);

            bool isUserReady = true;
            Console.WriteLine(isUserReady);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime dateOfBirth = new DateTime(1993, 1, 29);
            Console.WriteLine(dateOfBirth);

            //liczby całkowite
            //byte, sbyte (8bit)
            //short, ushort (16bit)
            //int, uint (32bit)
            //long, ulong (64bit)

            byte byteNumber = 200;
            //za dużo dla byte: byte byteNumber = 500;

            // liczby zmienno-przecinkowe
            // float (32bit)
            // double (64bit)
            // decimal (128bit) - type for financial and monetary calculations

            //F,f - sufix określający typ liczby jako float
            //M - jako decimal
            //przy double nie trzeba

            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;

            // STRINGI maks. rozmiar ok. 2GB, lub 1 miliarda znaków
            string message1;
            message1 = "some value";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);

            string message3 = string.Empty;
            Console.WriteLine(message3);
            //string.Empty != null

            string text = "He said \"Hi\"";
            Console.WriteLine(text);
            string windowLocation = "c:\\windows";
            Console.WriteLine(windowLocation);
            string fontsFolder = @"c:\windows\fonts";
            Console.WriteLine(fontsFolder);
            // nie zadziała dla ", np.  @"He said "Hi"";
            //string.Concat(text, text2) pozwala na łączenie tekstów, działa tak samo jak +
            string concatenated = string.Concat(text, " to ", "me");
            Console.WriteLine(concatenated);
            string concatenated2 = text + " to " + "me";
            Console.WriteLine(concatenated2);
            //interpolacja
            string interpolated = $"{text} to me";
            Console.WriteLine(interpolated);

            //nadpisanie stringa powoduje zajęcie drugiego miesjca w pamięci.
            // Żeby tego uniknąć możemy użyć stringBuilder
            StringBuilder sb = new StringBuilder("This");
            sb.Append(" is");
            sb.Append(" a");
            sb.Append(" long");
            sb.Append(" text.");

            string stringResult = sb.ToString();
            Console.WriteLine(stringResult);
        }

        public static void Operatory()
        {
            // OPERATORY
            int result;
            int x = 10;
            int y = 5;

            Console.WriteLine("*** OPERATORY ***");
            Console.WriteLine("x = 10. y = 5");
            // +
            result = x + y;
            Console.WriteLine("Addition Operator: x + y = " + result);
            // -
            result = x - y;
            Console.WriteLine("Subtraction Operator: x - y = " + result);
            // *
            result = x * y;
            Console.WriteLine("Multiplication Operator: x * y = " + result);
            // /
            result = x / y;
            Console.WriteLine("Divison Operator: x / y = " + result);
            // % (modulo)
            result = x % y;
            Console.WriteLine("Modulo Operator: x % y = " + result);


            int value1 = 10;
            int value2 = 10;
            //Inkementacja jest możliwa dla liczb całkowitych
            Console.WriteLine("Pre increment result: ++value");
            Console.WriteLine(++value1);
            Console.WriteLine(value1);
            Console.WriteLine("Post increment result: value++");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);

            Console.WriteLine("Operatory relacyjne - wynik bool");
            bool boolResult;

            x = 2;
            y = 10;

            Console.WriteLine("x = 2. y = 10");

            boolResult = x == y;
            Console.WriteLine("Equal to Operator: (x == y) = " + boolResult);
            boolResult = x > y;
            Console.WriteLine("Grater than Operator: (x > y) = " + boolResult);
            boolResult = x < y;
            Console.WriteLine("Less than Operator: (x < y) = " + boolResult);
            boolResult = x >= y;
            Console.WriteLine("Grater than or equal to Operator: (x >= y) = " + boolResult);
            boolResult = x <= y;
            Console.WriteLine("Less than or equal to Operator: (x <= y) = " + boolResult);
            boolResult = x != y;
            Console.WriteLine("Not Equal to Operator: (x != y) = " + boolResult);

            bool a = true;
            bool b = false;

            Console.WriteLine("Operatory logiczne:");

            boolResult = a && b;
            Console.WriteLine("AND Operator: a && b = " + boolResult);
            boolResult = a || b;
            Console.WriteLine("OR Operator: a || b = " + boolResult);
            boolResult = !a;
            Console.WriteLine("NOT Operator: !a = " + boolResult);
            //Przy porównywaniu więcej niż dwóch wyrażeń, kolejność jest od lewej do prawej,
            //chyba, że zastosujemy nawiasy.

            // TRÓJSKŁADNIKOWY OPERATOR WARUNKOWY - czyli skrócony IF
            // warunek logiczny ? true : false
            x = 5;
            y = 10;
            Console.WriteLine("x = 5. y = 10");
            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);
        }

        public static void KonwersjaTypow()
        {
            Console.WriteLine("Konwersja typów i rzutowanie");
            //konwersja stringa na liczbę
            Console.WriteLine("Podaj rok urodzenia:");
            string UserInput = Console.ReadLine();
            int yearOfBirth = int.Parse(UserInput);
            float floatWalue = float.Parse(UserInput);
            short shortValue = short.Parse(UserInput);

            if (int.TryParse(UserInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine("You are " + age);
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }

            //Konwersja między typami liczbowymi

            //Niejawna
            byte byteValue = 100;
            int intValue = byteValue; // w drugą stronę się tak nie da.

            //jawna, ze wskazanym rzutowaniem:
            byte byteValue2 = (byte)intValue;

            //możemy każdy typ sprowadzić do stringa metodą .ToString()
            string stringValue = byteValue.ToString();
        }

        public static void NullableType()
        {
            //NULLABLE
            //int? == Nullable<int>
            Console.WriteLine("Wprowadź ulubioną liczbę:");
            int? favoriteNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Favorite number: " + (favoriteNumber.HasValue ? favoriteNumber.ToString() : ""));
        }

        public static void TryCatch()
        {
            //TRY CATCH

            string[] cars = { "Volvo", "BMW", "Mazda" };

            //cars[4] = "Tesla"; //throws System.IndexOutOfRangeException

            try
            {
                //code that might thrown an exception
                Console.WriteLine("Inside try - 1");
                cars[4] = "Tesla";
                Console.WriteLine("Inside try - 2");
            }
            catch (IndexOutOfRangeException e)
            {
                //code which is executed only when exception is caught
                Console.WriteLine("Handling IndexOutOfRangeException exception");
            }
            catch (Exception e) //default
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("Outside of try-catch.");
        }

        public static void RegexExpression()
        {
            /* Zadanie: Utwórz Regex, który sprawdzi czy adres email jest prawidłowy.
             * Założenia:
             * - Adres email składa się z 2 części oddzielonych znakiem '@'
             * - Pierwsza część dopuszcza tylko litery, cyfry i znak '.', z tym, że
             * nie może być on na początku ani na końcu tej części
             * - Druga część składa się z hosta (dowolny ciąg znaków), kropki i domeny
             * (dowolny ciąg znaków w zakresie długości [2,3])
             */

            // Wyrażenia regularne - REGEX
            // strona do tworzenia REGEX'u: https://regexr.com/
            Regex regex = new Regex(@"^[a-z0-9]+\.?[a-z0-9]+@[a-z]+\.[a-z]{2,3}$");
            string email = "test.2@hotmail.com";
            bool isMatch = regex.IsMatch(email);
            Console.WriteLine(isMatch);
        }
    }
}
