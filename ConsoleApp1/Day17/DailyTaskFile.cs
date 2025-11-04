using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Day17
{
    internal class DailyTaskFile
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        int a, b;
        public DailyTaskFile()
        {
            FolderInitialization();
            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Choose an operation: 1.Add 2.Subtract 3.Multiply 4.Divide 5.BackUp 6.Exit    ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Add(a, b);
                        break;
                    case 2:
                        Subtract(a, b);
                        break;
                    case 3:
                        Multiply(a, b);
                        break;
                    case 4:
                        Divide(a, b);
                        break;
                    case 5:
                        LogBackUp();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        throw new ArgumentException("Invalid choice. Please try again.");
                }

            } while (true);


        }
        public void Add(int a,int b)
        {
            String text = $"Executing Addition function \n The sum of two values {a} and {b} : {a + b}\n";
            Console.WriteLine("Sum: " + (a + b));
            FileCreationOperation(text);
            
        }
        public void Subtract(int a,int b)
        {
            String text = $"Executing Subtraction function \n The subtraction of two values {a} and {b} : {a - b}\n";
            Console.WriteLine("Difference: " + (a - b));
            FileCreationOperation(text);
        }
        public void Multiply(int a,int b)
        {
            String text = $"Executing Multiplication function \n The Multiplication of two values {a} and {b} : {a * b}\n";
            Console.WriteLine("Product: " + (a * b));
            FileCreationOperation(text);
        }
        public void Divide(int a,int b)
        {
            try
            {
                if(b == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be zero.");
                }
                String text = $"Executing Division function \n The Division of two values {a} and {b} : {a/b}\n";
                Console.WriteLine("Quotient: " + (a / b));
                FileCreationOperation(text);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                FileCreationErrorLog(ex.Message);
            }
        }

        // Folder Initialize
        public void FolderInitialization()
        {
            Console.WriteLine("Folder Initialization method called.");
            string Op = "D:\\DailyTasks\\Operations";
            string err = "D:\\DailyTasks\\Errors";
            string back = "D:\\DailyTasks\\BackUp";
            Directory.CreateDirectory(Op);
            Directory.CreateDirectory(err);
            Directory.CreateDirectory(back);
            Console.WriteLine("Folders created");

        }

        // Operation File creation
        public void FileCreationOperation(String text)
        {
            String fileName = "D:\\DailyTasks\\Operations\\OperationLog_" + today.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, text);
            }
            else
            {
                File.AppendAllText(fileName, text);
            }
            Console.WriteLine("==============Results Added to file successfully=============\n");
        }


        // Error Log File creation
        public void FileCreationErrorLog(String text)
        {
            String fileName = "D:\\DailyTasks\\Errors\\ErrorLog_" + today.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, text);
            }
            else
            {
                File.AppendAllText(fileName, text);
            }
            Console.WriteLine("==============ErrorLog Added to file successfully=============\n");
        }

        // BackUp 
        public void LogBackUp()
        {
            string destination = @"D:\DailyTasks\BackUp";
            String sourceFolder = "D:\\DailyTasks\\Operations";
            String[] files=Directory.GetFiles(sourceFolder);
            if (files.Length == 0)
            {
                Console.WriteLine("No files found in the source folder.");
                return;
            }

            foreach (String file in files) { 
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Length <= 1 * 1024 * 1024)
                {
                    string destinationPath=Path.Combine(destination, fileInfo.Name);
                    fileInfo.MoveTo(destinationPath);
                }
            }
            Console.WriteLine("===== BackUp Successfull =========\n");
        }
    }
}
