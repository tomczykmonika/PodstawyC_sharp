using PodstawyC_.Module2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    public class LINQ_Person
    {
        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
            };
            return employees;
        }
        public static void PersonExample() 
        {
            List<Person> employees = GetEmployees();

            // Zadanie: Wyświetl pracowników urodzonych po 2000-01-01
            //Jeżeli ma na imię Bob wywołaj metodę "Say Hi"

            // Nieefektowny kod z użyciem pętli i IF'ów - bez LINQ
            /*
            List<Person> youngEmployees = new List<Person>();
            foreach (Person employee in employees) 
            {
                if (employee.GetDateOfBirth() > new DateTime(2000, 1, 1))
                {
                    youngEmployees.Add(employee);
                }
            }
            Console.WriteLine($"Young employees count: {youngEmployees.Count}");

            Person bob = null;
            foreach(Person youngEmployee in youngEmployees)
            {
                if(youngEmployee.FirstName == "Bob")
                {
                    bob = youngEmployee;
                    break;
                }
            }
            if(bob != null) 
            {
                bob.SayHi(); 
            }
            else
            {
                Console.WriteLine("Bob not found");
            }
            */

            // z LINQ, ale bez LAMBDY
            /*
            // EmployeeIsYoung to predykat dla typu Person.
            //Predykat zawsze zwraca wartość bool

            List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList();
            bool EmployeeIsYoung(Person employee)
            {
                return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
            }
            Console.WriteLine($"Young employees count {youngEmployees.Count}");

            Person bob = youngEmployees.FirstOrDefault(EmployeeIsBob);
            bool EmployeeIsBob(Person employee) 
            {
                return employee.FirstName == "Bob";
            }

            if(bob != null) 
            {
                bob.SayHi(); 
            }
            else
            {
                Console.WriteLine("Bob not found");
            }
            */

            List<Person> youngEmployees = employees.Where(e => e.GetDateOfBirth() > new DateTime(2000, 1, 1)).ToList();
            Console.WriteLine($"Young employees count {youngEmployees.Count}");

            Person bob = youngEmployees.FirstOrDefault(e => e.FirstName == "Bob");
           
            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                Console.WriteLine("Bob not found");
            }
        }
    }
}
