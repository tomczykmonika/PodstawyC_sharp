using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    internal class Listy
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int i in list)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
        public static void ListyExample()
        {
            // *** Kolekcje - LISTY
            //Tablice nie wchodzą w kolekcje, mają stałą długość,
            //w kolekcjach długość można zmieniać dynamicznie.    
            List<int> intList = new List<int>() { 8, 1, 20 };
            intList.Add(6);
            DisplayElements(intList);

            Console.WriteLine("New element: ");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);
            DisplayElements(intList);


            // USUWANIE ELEMENTÓW Z LISTY

            // 1 sposób
            List<int> intList1 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            intList1.RemoveAt(2); // 20 zostanie usunięte -> {6, 1, 3, 45, 60, 100, 2 }

            // 2 sposób
            bool IsGreaterThan5(int x)
            {
                return x > 5;
            }

            List<int> intList2 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            intList2.RemoveAll(IsGreaterThan5);
            // wszystkie wartości większe niż 5 zostaną usunięte, zostane {3,1,2}

            // 3 sposób
            List<int> intList3 = new List<int>() { 1, 2, 1 };
            intList3.Remove(1); // usunie 1 pasujący przypadek, zostanie: {2, 1}

            // 4 sposób (index, ilosc)
            List<int> intList4 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            intList4.RemoveRange(2, 3); // usunięte 20,3,45 -> {6, 1, 60, 100, 2 }


            // SORTOWANIE LISTY
            List<int> intList5 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            DisplayElements(intList5);
            intList5.Sort();
            Console.WriteLine("Sort:");
            DisplayElements(intList5);
        }
    }
}
