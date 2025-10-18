using ConsoleApp1.Day2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Day_8
{
    internal class ReverseAString
    {
        public ReverseAString()
        {
            //Console.Write("Enter the String1 : ");
            //String word1= Console.ReadLine();
            //Console.Write("Enter the String2 : ");
            //String word2= Console.ReadLine();

            //Console.Write("Enter the sentence: ");
            //String sentence = Console.ReadLine();

            //Char[] arr = word1.ToCharArray();

            //Vowels(arr);  // to check vowels

            //RemoveDuplicates(word1);

            //ToUpperCase(sentence); // to convert first letter of each word to uppercase

            //Array.Reverse(arr);
            //String reverseWord = String.Join("", arr);
            //Console.WriteLine($"Reversed word of string {word1} : ");
            //Console.WriteLine(reverseWord);

            //AnagramCheck(word1, word2); // to check anagram


            //Console.Write("Enter the strong password: ");
            //String password=Console.ReadLine();
            //PasswordStrengthCheck(password);

            //Console.Write("Enter the mail");
            //String mailId=Console.ReadLine();
            //ExtractEmail(mailId);

            //Console.Write("Enter the card number with spaces: ");
            //String cardNum=Console.ReadLine();
            //Maskedcard(cardNum);

            //Console.Write("Enter the fullname followed by initial (eg : Subash Chandra Bose S): ");
            //String fullName=Console.ReadLine();
            //InitialExtract(fullName);

            //Console.Write("Enter the Sentence with hashtags (#) : ");
            //String hashTagSentence = Console.ReadLine();
            //ExtractHashTags(hashTagSentence);

            //Console.Write("Enter the url like (https://www.google.com): ");
            //String url = Console.ReadLine();
            //ExtractUrl(url);

            //Console.Write("Enter the number : ");
            //String numberEntered = Console.ReadLine();
            //ExtractNumber(numberEntered);

            //Console.Write("Enter the sentence : ");
            //String truncateSentence = Console.ReadLine();
            //TruncateString(truncateSentence , 20);

            //Console.Write("Enter the sentence : ");
            //String countWordsFreq = Console.ReadLine();
            //CountWordsFrequency(countWordsFreq);

            Console.WriteLine("Enter the sentence : ");
            String keySentence=Console.ReadLine();
            Console.Write("Enter the number of keywords : ");
            int size=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the keyWords :");
            String []keywords = new string [size];

            for (int i = 0; i < size; i++) {
                keywords[i] = Console.ReadLine();
            }

            HightlightKeywords(keySentence, keywords);





        }

        public void Palindrome(String word, String reversedWord)
        {
            if (word == reversedWord) Console.WriteLine($"{word} is a palindrome");
            else Console.WriteLine($"{word} is not a palindrome");
        }

        public void Vowels(Char[] arr)
        {
            int vowelCount = 0;
            foreach (char c in arr)
            {
                if ("aeiouAEIOU".Contains(c)) vowelCount++;
            }
            Console.WriteLine($"The no of vowels in the string {String.Join("", arr)} is {vowelCount}");
        }

        public void RemoveDuplicates(String word)
        {
            String dupli = new string(word.Distinct().ToArray());
            Console.WriteLine($"The String after removing the dulplicate is {dupli}");
        }

        public void ToUpperCase(String sentence)
        {

            String[] arr = sentence.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            }
            String result = String.Join(" ", arr);
            Console.WriteLine($"The sentence after converting to uppercase is : {result}");
        }

        public void RemoveWhiteSpaces(String sentence)
        {
            String result = sentence.Replace(" ", "");
            Console.WriteLine($"The sentence after removing whitespaces is : {result}");
        }

        public void FrequencyOfCharacters(String word)
        {
            Char[] arr = word.ToCharArray();
            Dictionary<Char, int> freq = new Dictionary<Char, int>();
            foreach (Char c in arr)
            {
                if (freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }
            foreach (var item in freq)
            {
                Console.WriteLine($"Character: {item.Key}, Frequency: {item.Value}");
            }
            int maxCount = 0;
            Char maxChar = ' ';
            foreach (var item in freq)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    maxChar = item.Key;
                }
            }
            Console.WriteLine($"The character with maximum frequency is '{maxChar}' with frequency {maxCount}");

        }

        public void AnagramCheck(String word1, String word2)
        {
            char[] arr1 = word1.ToLower().ToCharArray();
            char[] arr2 = word2.ToLower().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            if (new string(arr1) == new string(arr2))
            {
                Console.WriteLine($"{word1} and {word2} are anagrams");
            }
            else
            {
                Console.WriteLine($"{word1} and {word2} are not anagrams");
            }
        }

        public void ValidEmail(String email)
        {
            Console.WriteLine(email.Contains("@") && email.Contains(".") ? "Valid Email" : "Invalid Email");
        }

        public void ValidatePhoneNumber(String phoneNumber)
        {
            Console.WriteLine(phoneNumber.Length == 10 && long.TryParse(phoneNumber, out _) ? "The phone number entered is valid" : "The phone number entered is In valid");
        }

        public void CheckOnlyDigits(String input)
        {
            Console.WriteLine(long.TryParse(input, out _) ? "The input contains only digits" : "The input contains non-digit characters");
        }


        public void PasswordStrengthCheck(String password)
        {
            int symbolCount = 0, upperCase = 0;
            if (password.Length < 8)
            {
                Console.WriteLine("Enter the strong password of length greater than 10");
                return;
            }
            Char[] arr = password.ToCharArray();
            foreach (char c in arr)
            {
                if (Char.IsUpper(c)) upperCase++;
                else if (!Char.IsLetterOrDigit(c)) symbolCount++;
            }
            Console.WriteLine((symbolCount > 0 && upperCase > 0) ? "" : "Enter the strong password with capital letters and Symbols");
        }

        public void ExtractEmail(String email)
        {
            int index = email.IndexOf("@");
            String mail = email.Substring(index + 1);
            Console.WriteLine("The mail belongs to " + mail + " domain");

        }

        public void Maskedcard(String word)
        {
            int digitsMasked = 0;
            String maskedCard = "";
            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                {
                    if (digitsMasked < 12)
                    {
                        maskedCard += '*';
                        digitsMasked++;
                    }
                    else
                    {
                        maskedCard += c;
                    }
                }
                else maskedCard += c;


            }
            Console.Write(maskedCard);


        }

        public void InitialExtract(String name)
        {
            //String[] arr = name.Split(" ");
            Console.WriteLine($"The initial is : {name.Split(" ", StringSplitOptions.RemoveEmptyEntries)[^1]}.");  // ^1 returns the last element
        }

        public void ExtractHashTags(String sentence)
        {
            var matches = Regex.Matches(sentence, @"#\w+");
            Console.WriteLine("The hashtags in the sentence are : ");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }

        public void ExtractUrl(String url)
        {
            var match = Regex.Match(url, @"https?://[\w\-\.]+");   //regular exp , https? means http or https, [\w\-\.]+ means any word character, hyphen or dot one or more times
            if (match.Success)
            {
                Console.WriteLine("URL found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No URL found.");
            }

        }
        public void ExtractNumber(String number)
        {
            var match = Regex.Match(number, @"\d+");   //regular exp , https? means http or https, [\w\-\.]+ means any word character, hyphen or dot one or more times
            if (match.Success)
            {
                Console.WriteLine("URL found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No URL found.");
            }

        }

        public void TruncateString(String sentence, int maxLength)
        {
            if(sentence.Length <= maxLength)
            {
                Console.WriteLine($"The string is within the limit : {sentence}");
                return;
            }
            String turncate = sentence.Substring(0,maxLength) +"...";
            Console.WriteLine($"The truncated string is : {turncate}");
        }

        public void CountWordsFrequency(String sentence)
        {
            var matches = Regex.Matches(sentence, @"\b\w+\b", RegexOptions.IgnoreCase); // \b indicates word boundary, \w+ indicates one or more word characters

            Dictionary<String,int> wordsFreq = new Dictionary<String,int>();
            foreach (Match match in matches)
            {
                String word = match.Value.ToLower();
                if(wordsFreq.ContainsKey(word))
                {
                    wordsFreq[word]++;
                }
                else
                {
                    wordsFreq[word] = 1;
                }

            }

            foreach(var item in wordsFreq)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        public void HightlightKeywords(String sentence, String[] keywords) {
            for (int i = 0; i < keywords.Length; i++) keywords[i]=Regex.Escape(keywords[i]); // C++ => c\\+\\+
            //verbatim string literals (with @):
            String pattern = @"\b(" + String.Join("|", keywords) + @")\b";  // \b(Switzerland | Norway | Germany)\b

            String replacedString = Regex.Replace(sentence,pattern,m => $"<b>{m.Value}</b>",RegexOptions.IgnoreCase);

            Console.WriteLine(replacedString);
        }
    }
}
