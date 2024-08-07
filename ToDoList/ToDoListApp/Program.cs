using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            List<string> toDoList = new List<string>(); 
            
            Console.WriteLine("Madelenes To Do List");
            
            Console.WriteLine("Please add new task");
            
            task = Console.ReadLine();
         
            toDoList.Add(task);
           

            
            foreach (string toDoes in toDoList)
            {
                Console.WriteLine(task);
            }

            Console.ReadKey();
        }
    }
}
