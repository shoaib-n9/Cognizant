using System;
using System.Globalization;

namespace DateEx1 //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the method here

        public static int CalculateAge(string dateOfBirth)
        {
            string format = "MM/dd/yyyy";

            DateTime dob = DateTime.ParseExact(dateOfBirth, format, CultureInfo.InvariantCulture, DateTimeStyles.None);

            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - dob.Year;

            if (currentDate.Month < dob.Month || (currentDate.Month == dob.Month && currentDate.Day < dob.Day))
            {
                age--;
            }
            return age;
        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Console.WriteLine("Enter the date of birth");
            string dobInput = Console.ReadLine();

            int calculatedAge = CalculateAge(dobInput);
            Console.WriteLine(calculatedAge);
        }
    }
}
