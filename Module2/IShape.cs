using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    /*Opis zadania : Twoim zadaniem jest stworzenie programu, 
     * który będzie obsługiwał różne kształty geometryczne. 
     * Program ma umożliwiać obliczanie pola powierzchni i obwodu dla każdego kształtu.
     * Wymagania:
     * - Utwórz interfejs IShape zawierający metody CalculateArea i CalculatePerimeter.
     * - Utwórz klasy implementujące interfejs IShape dla przynajmniej 
     * dwóch różnych kształtów (np. kwadrat, koło).
     * Każda klasa powinna posiadać odpowiednie pola i konstruktor(y) 
     * oraz implementacje metod CalculateArea i CalculatePerimeter.
    */
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class Circle_od_interface : IShape
    {
        private double radius;

        public Circle_od_interface(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Square_od_interface : IShape
    {
        private double side;

        public Square_od_interface(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
