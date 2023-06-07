using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<string>();
            
            Console.WriteLine("Hello!");

            bool shallExit = false; //perulangan tampilan menu
            while (!shallExit)
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");
                Console.WriteLine();

                Console.WriteLine("Select [S][A][R][E] options");
                Console.Write("I want to: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "S":
                    case "s":
                        {
                            SeeAllTodo();
                            break;
                        }
                    case "A":
                    case "a":
                        {
                            AddTodo();
                            break;
                        }
                    case "R":
                    case "r":
                        {
                            RemoveTodo();
                            break;
                        }
                    case "E":
                    case "e":
                        {
                            shallExit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                }
                void AddTodo()
                {
                    Console.WriteLine("Enter the TODO description: ");
                    string description = Console.ReadLine();

                    bool isValidDescription = false;
                    while (!isValidDescription)
                    {
                        if (description == "")
                        {
                            Console.WriteLine("The description cannot be empty");
                        }
                        else if (todos.Contains(description))
                        {
                            Console.WriteLine("The description must be unique");
                        }
                        else
                        {
                            todos.Add(description);
                            isValidDescription = true;
                        }
                    }  
                }
                void SeeAllTodo()
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("No TODO have been added yet");
                    }
                    else
                    {
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{todos[i]}");
                        }
                    }
                }
                void RemoveTodo()
                {
                    string userInput2;
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("No TODO have been added yet");
                        return;
                    }
                    bool isIndexValid = false;
                    while (!isIndexValid)
                    {
                        Console.WriteLine("Select the index of the TODO you want to remove");
                        SeeAllTodo();
                        userInput2 = Console.ReadLine();
                        if (userInput2 == "")
                        {
                            Console.WriteLine("Selected index cannot be empty");
                            continue; //go back to beginning loop
                        }
                        if(int.TryParse(userInput2, out int index) && index >=1 && index <= todos.Count)
                        {
                            var indexOfTodo = index - 1;
                            var todoToBeRemoved = todos[indexOfTodo];
                            todos.RemoveAt(indexOfTodo);
                            isIndexValid = true;
                            Console.WriteLine("TODO removed: " + todoToBeRemoved);
                        }
                        else
                        {
                            Console.WriteLine("The given index is not valid.");
                        }
                    }
                }
            }
        }
    }
}
