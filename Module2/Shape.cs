using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    //Polimorfizm
    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        // virtual - pozwala na ustawienie "domyślnej" implementacji metody
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    class Circle : Shape
    {
        //Jeżeli usuniemy słowo override to zostanie wywołana metoda z klasy bazowej.
        //Drawing shape.
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }
}
