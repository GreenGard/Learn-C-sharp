using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>(); // En lista av strängar
            
            // Lägg till några uppgifter
            tasks.Add("Simma");
            tasks.Add("Springa");
            tasks.Add("Leka");

            // Visa uppgifterna
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
