using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RegularExpression //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement your method here

        public string[] FindWords(string sentence, char startChar, char endChar)
        {
            string pattern = $@"\b{Regex.Escape(startChar.ToString())}\w*{Regex.Escape(endChar.ToString())}\b";

            MatchCollection matches = Regex.Matches(sentence, pattern, RegexOptions.IgnoreCase); // Using IgnoreCase for robustness

            List<string> foundWords = new List<string>();

            foreach (Match match in matches)
            {
                foundWords.Add(match.Value);
            }

            return foundWords.ToArray();
        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here

            Program programInstance = new Program();

            Console.WriteLine("Enter the sentence");
            string sentenceInput = Console.ReadLine();

            Console.WriteLine("Enter the starting character");
            char startCharInput;

            if (!char.TryParse(Console.ReadLine(), out startCharInput))
            {
                Console.WriteLine("Invalid starting character. Please enter a single character.");
                return;
            }


            Console.WriteLine("Enter the ending character");
            char endCharInput;

            if (!char.TryParse(Console.ReadLine(), out endCharInput))
            {
                Console.WriteLine("Invalid ending character. Please enter a single character.");
                return;
            }

            string[] resultWords = programInstance.FindWords(sentenceInput, startCharInput, endCharInput);

            Console.WriteLine("The words are below :");

            if (resultWords.Length > 0)
            {
                foreach (string word in resultWords)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
