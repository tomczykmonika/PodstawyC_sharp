using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    /*Opis: 
     * Twoim zadaniem jest stworzenie programu do zarządzania ocenami uczniów. 
     * Program ma umożliwiać dodawanie ocen, usuwanie ocen oraz obliczanie średniej ocen 
     * dla każdego ucznia.
     * 
     * Wymagania:
     * - Zaimlementuj klasę GradeManager, która będzie przechowywać oceny uczniów w 
     * postaci słownika (Dictionary<string, List<int>>), 
     * gdzie klucz to imię ucznia, a wartość to lista ocen.
     * - Dokończ metody AddGrade, RemoveGrade i CalculateAverageGrade 
     * do odpowiednio dodawania, usuwania i obliczania średniej ocen dla uczniów. */

    public class GradeManager
    {
        private Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

        public void AddGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
            {
                if (!grades.ContainsKey(studentName))
                {
                    grades[studentName] = new List<int>();
                }
                grades[studentName].Add(grade);
            }
        }

        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
            {
                if (grades.ContainsKey(studentName))
                {
                    grades[studentName].Remove(grade);
                }
            }
        }

        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (grades.ContainsKey(studentName) && grades[studentName].Count > 0)
            {
                return grades[studentName].Average();
            }
            return 0.0;
        }

        public static void GradeExample()
        {
            GradeManager grade = new GradeManager();

            grade.AddGrade("Kowalski",3);
            grade.AddGrade("Kowalski", 5);
            Console.WriteLine(grade.CalculateAverageGrade("Kowalski"));
            grade.RemoveGrade("Kowalski", 3);
            Console.WriteLine(grade.CalculateAverageGrade("Kowalski"));
        }
    }
}
