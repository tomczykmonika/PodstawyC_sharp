using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        //element statyczny. Nie można się do niego odwołać przez obiekt danego klasy ,np. bill.Count, natomiast Person.Count zadziała - tę możliwość mamy dzięki słowo static.
        //Statyczna może być zmienna, właściwość lub metoda. 
        public static int Count = 0;
        
        //KONSTRUKTORY:
        //Konstruktor domyślny (zawsze jest, nawet jak go nie widać ;)
        public Person()
        {
            //Console.WriteLine("Constructor 0");
            Count++;
        }

        public Person(string firstName, string lastName) : this()
        {
            //Console.WriteLine("Constructor 1");
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(DateTime dateofBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            //Console.WriteLine("Constructor 2");
            SetDateOfBirth(dateofBirth);
        }

        public void SetDateOfBirth(DateTime data)
        {
            if (data > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth.");
            }
            else
            {
                dateOfBirth = data;
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;
        /* => dateOfBirth; znaczy tyle samo co:
        {
            return dateOfBirth;
        }
        */
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }

        // Właściwość klasy - akcesor (get, set),
        // zamiast wywoływać metodę mamy wrażenie że odwołujemy się bezpośrednio do obiektu tej klasy.
        private string contactNumber;
        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {

                if (value.Length < 9)
                {
                    Console.WriteLine("Invalide contact number.");
                }
                else
                {
                    contactNumber = value;
                }
            }
        }

        // Jeżeli występują tylko akcesory get i set, implementacje możemy skrócić do 1 linii.
        //Nie musimy wtedy robić osobnego obiektu Private i metody public.
        public string Country { get; set; }


        


        



        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1990, 2, 21), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 21), "John", "Wick"),
                new Person(new DateTime(1996, 4, 21), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 21), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 21), "John", "Smith"),
                new Person(new DateTime(2005, 2, 21), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 21), "Ed", "Smith"),
            };
            return employees;
        }
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int i in list)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }

        public static void PersonExample()
        {
            Person bill = new Person();
            bill.FirstName = "Bill";
            bill.SetDateOfBirth(new DateTime(1990, 1, 1));
            bill.SayHi();
            //Korzystanie z akcesorów (właściwości klas get,set):
            bill.ContactNumber = "999888777";
            Console.WriteLine(bill.ContactNumber);

            Console.WriteLine($"Objects of Person type count: {Person.Count}");
        }
    }
}