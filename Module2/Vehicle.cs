using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{   /*Zadanie praktyczne: Dziedziczenie w hierarchii pojazdów
     * Opis: Twoim zadaniem jest stworzenie hierarchii klas reprezentujących różne rodzaje pojazdów. 
     * Klasa nadrzędna powinna zawierać podstawowe metody i właściwości, 
     * a klasy pochodne powinny dziedziczyć te cechy i dodatkowo implementować swoje.
     * 
     * Wymagania:
     * - Utwórz klasę nadrzędną Vehicle zawierającą właściwość Model (nazwa pojazdu) 
     * oraz abstrakcyjne metody Start i Stop.
     * - Utwórz co najmniej dwie klasy dziedziczące po klasie Vehicle (np. Car i Motorcycle), 
     * które implementują metody Start i Stop w sposób odpowiedni dla każdego pojazdu.
     * - Metoda Start powinna wypisać do konsoli "Starting the car: {Model}" i 
     * analogicznie "Starting the motorcycle: {Model}", dla odpowiedniej klasy
     * - Metoda Stop powinna wypisać do konsoli "Stopping the car: {Model}" i 
     * analogicznie "Stopping the motorcycle: {Model}", dla odpowiedniej klasy
     */

    public abstract class Vehicle
    {
        public string Model;
        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping the car: {Model}");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }
    }
}
