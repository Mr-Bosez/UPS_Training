using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_8
{
    internal class StringOperations
    {
        public StringOperations()
        {
            //string firstName = "Subash chandra bose";
            //string lastName = " s";
            //int age = 21;
            //Console.WriteLine($"I'm {firstName+ lastName} and my age is {age}");

            String sentence = "I am subash chandra bose from Tirunelveli";

            String[] arr = sentence.Split(" ");
            Console.WriteLine(String.Join(",", arr));

            String email = "subash@gmail.com";

            Console.WriteLine(email.Substring(email.IndexOf('@')));  // substring

            //Console.WriteLine(string.Compare("abc", "abc"));

            String filename = "String operations.cs ";
            filename=filename.TrimEnd();
            Console.WriteLine(filename.Replace(" ", "_"));

            //Console.WriteLine((email.Contains("@gmail.com")) ? "It's  a google account" : email.Substring(email.IndexOf('@')));

            String[] mailId = ["mrbose@gmail.com", "subash@gmail.com", "Bose@gmail.com"];
            Console.Write(String.Join(" ; ", mailId));

            String sentence2 = string.Copy(sentence);
            Console.WriteLine("\n"+sentence2);


            String email2 = "bose2004@gmail.com";
            int count = 0;
            foreach(char a in email2)
            {
                if (char .IsDigit(a))
                {
                    count++;
                }
                else if (!char.IsLetterOrDigit(a))
                {
                    Console.WriteLine($"The special character in the email is {a}");

                }
            }
            Console.WriteLine($"The email has {count} digits");


            String paragraph = "I am subash chandra bose from Tirunelveli TamilNadu.I am currently purusing B tech at computer science";
        
            String[] Words = paragraph.Split(" ");
            String[] arrSentences = paragraph.Split(".");

            Console.WriteLine($"No of words in the paragraph is {Words.Length}");
            Console.WriteLine($"No of sentences in the paragraph is {arrSentences.Length}");

            Console.WriteLine(String.Join(",", Words));
            Console.WriteLine(String.Join(",", arrSentences));

        }
    }
}
