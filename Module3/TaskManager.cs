using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    /* Opis: 
     * Twoim zadaniem jest napisanie programu do zarządzania listą zadaniami "task". 
     * Program ma umożliwiać dodawanie nowych zadań, 
     * usuwanie istniejących zadań oraz wyświetlanie listy zadań.
     * 
     * Wymagania:
     * - Utwórz klasę TaskManager, która będzie przechowywać listę zadań 
     * (np. w postaci listy obiektów string).
     * - Utwórz metody AddTask, RemoveTask i GetTasks do odpowiednio dodawania, 
     * usuwania i pobierania zadań z listy.
     */
    public class TaskManager
    {
        public List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task); // nawet jeśli zadanie nie isnieje, metoda Remove nie wyrzuci wyjątku, przez nie musimy sprawdzać czy element znajduję się w liście
        }

        public void GetTasks()
        {
            Console.WriteLine("** List **");
            foreach (string i in tasks)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
        
        public static void TaskExample()
        {
            TaskManager taski = new TaskManager();

            taski.AddTask("Nowe zadanie");
            taski.GetTasks();
            taski.RemoveTask("Nowe zadanie");
            taski.GetTasks();

        }
        
    }
}
