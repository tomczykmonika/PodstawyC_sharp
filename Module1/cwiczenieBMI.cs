using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module1
{
    internal class cwiczenieBMI
    {
        public static double CalculateBMI(double masa, double wzrost)
        {
            return masa / (wzrost * wzrost);
        }

        public static string TypeBMI(double BMI)
        {
            if (BMI > 35)
            {
                return "Otyłość olbrzymia";
            }
            else if (BMI >= 30)
            {
                return "Otyłość";
            }
            else if (BMI >= 25)
            {
                return "Nadwaga";
            }
            else if (BMI >= 18.5)
            {
                return "Waga normalna";
            }
            else
            {
                return "Niedowaga";
            }
        }
        public static void BMI()
        {
            //cwiczenie kalkulator BMI
            Console.Write("Podaj masę ciała (w kg): ");
            string masa = Console.ReadLine();
            Console.Write("Podaj wzrost (w cm): ");
            string wzrost = Console.ReadLine();

            double dMasa;
            double dWzrost;

            if (double.TryParse(masa, out dMasa) && double.TryParse(wzrost, out dWzrost))
            {
                double wartoscBMI = CalculateBMI(dMasa, dWzrost / 100);
                Console.WriteLine("Twoje BMI wynosi: " + wartoscBMI.ToString());
                string typBMI = TypeBMI(wartoscBMI);
                Console.WriteLine("Typ: " + typBMI);
            }
            else
            {
                Console.WriteLine("Incorrect value masa or wzrost.");
            }
        }
    }
}
