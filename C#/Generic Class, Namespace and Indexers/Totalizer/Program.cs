using System;
using IndexerExample;

namespace IndexerExample //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {

            UserInput userInput = new UserInput();

            Console.WriteLine("Enter the values");

            for (int i = 0; i < 5; i++)
            {
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    userInput[i] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid input for value {i + 1}. Please enter an integer.");
                    return;
                }
            }

            int sumOfValues = userInput.Sum();

            Console.WriteLine($"Sum of values : {sumOfValues}");


        }
    }
}