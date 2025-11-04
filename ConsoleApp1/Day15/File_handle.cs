using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day15
{
    internal class File_handle
    {
        readonly String filePath;
        readonly bool exit = false;
        public File_handle(String filePath)
        {

            this.filePath = filePath;
            do
            {
                Console.WriteLine("1. Add Record");
                Console.WriteLine("2. Read Records");
                Console.WriteLine("3. Find Records");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddFile(filePath);
                        break;
                    case 2:
                        ReadFile(filePath);
                        break;
                    case 3:
                        FindRecords(filePath);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }


            } while (!exit);
        }


        public void AddFile(String filePath)
        {
            Console.WriteLine("==== Addind into file=====");
            Console.Write("Enter the name : ");
            String name = Console.ReadLine();
            Console.Write("Enter the age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the gender : ");
            string gender = Console.ReadLine();
            String text = $"{name} {age} {gender}\n";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, text);
            }
            else
            {
                File.AppendAllText(filePath, text);
            }
            Console.WriteLine("Data added successfully.\n");
        }

        public void ReadFile(String filePath)
        {
            Console.WriteLine("==== Reading from file========\n");
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }

        public void FindRecords(String filePath)
        {
            bool found = false;
            Console.WriteLine("==== Finding Records ========\n");
            Console.Write("Enter the name to search: ");
            String name = Console.ReadLine();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                String[] parts = line.Split(' ');
                if (parts[0].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n{line}\n");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Record not found.");
            }
        }
    }
}
