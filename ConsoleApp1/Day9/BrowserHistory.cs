using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class BrowserHistory
    {
        public BrowserHistory() {
            Console.WriteLine("=== Browser History Simulator ===");
            Stack<String> browserHistory= new Stack<String>();
            String command;
            do
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Visit Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Current Page");
                Console.WriteLine("4. Show History");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice (1-5): ");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1": // Visit Page
                        Console.Write("Enter URL to visit: ");
                        string page = Console.ReadLine();
                        browserHistory.Push(page);
                        Console.WriteLine($"Visited: {page}");
                        break;

                    case "2": // Back
                        if (browserHistory.Count > 0)
                        {
                            string lastPage = browserHistory.Pop();
                            Console.WriteLine($"Went back from: {lastPage}");
                        }
                        else
                        {
                            Console.WriteLine("No pages in history to go back.");
                        }
                        break;

                    case "3": // Current Page
                        if (browserHistory.Count > 0)
                        {
                            Console.WriteLine($"Current Page: {browserHistory.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("No page currently open.");
                        }
                        break;

                    case "4": // Show History
                        Console.WriteLine("\n--- Browser History ---");
                        if (browserHistory.Count > 0)
                        {
                            foreach (var p in browserHistory)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("History is empty.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting browser simulation.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (command != "5");
        }
    }
}
