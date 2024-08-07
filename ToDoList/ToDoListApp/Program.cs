using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskCount = 0;
            List<string> toDoList = new List<string>();

            Console.WriteLine("Madelenes To Do List");
            while (taskCount < 5)
            {
                Console.WriteLine("Please add a new task (max 5):");
                string task = Console.ReadLine();
                toDoList.Add(task);
                Console.WriteLine("Task count: " + taskCount);
                taskCount++;
            }

            Console.WriteLine("Madelenes tasks:");
            foreach (string toDoes in toDoList)
            {
                Console.WriteLine(toDoes); 
            }

            Console.ReadKey();
        }
    }
}
