using System;
using System.Collections.Generic;

namespace Finding //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the method here
        public static string[] FindingString(object[] objects)
        {
            List<string> foundStrings = new List<string>();

            foreach (object obj in objects)
            {
                if (obj is string)
                {
                    string strValue = obj as string;

                    foundStrings.Add(strValue);
                }
            }
            return foundStrings.ToArray();
        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Console.WriteLine("Enter values separated by colon");
            string inputLine = Console.ReadLine();

            string[] parts = inputLine.Split(':', StringSplitOptions.RemoveEmptyEntries);

            object[] mixedObjects = new object[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i].Trim();

                if (int.TryParse(part, out int intVal))
                {
                    mixedObjects[i] = intVal;
                }

                else if (double.TryParse(part, out double doubleVal))
                {
                    mixedObjects[i] = doubleVal;
                }
                else if (bool.TryParse(part, out bool boolVal))
                {
                    mixedObjects[i] = boolVal;
                }

                else
                {
                    mixedObjects[i] = part;
                }
            }

            string[] extractedStrings = FindingString(mixedObjects);

            Console.WriteLine("\nSample Output :");

            foreach (string s in extractedStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
