using System;
using System.Globalization;

namespace DateEx2
{
    public class Program
    {
        private const string DateFormat = "MM/dd/yyyy";

        public string CustomerFeedback(string expectedDate, string installedDate)
        {
            DateTime expectedDt = DateTime.ParseExact(expectedDate, DateFormat, CultureInfo.InvariantCulture);
            DateTime installedDt = DateTime.ParseExact(installedDate, DateFormat, CultureInfo.InvariantCulture);

            TimeSpan difference = installedDt - expectedDt;
            int daysDifference = (int)difference.TotalDays; // Cast to int to get whole days

            if (daysDifference < 0)
            {
                return "VeryGood";
            }
            else if (daysDifference == 0)
            {
                return "Good";
            }
            else if (daysDifference > 0 && daysDifference <= 3)
            {
                return "Average";
            }
            else
            {
                return "Poor";
            }
        }

        public string FindTheInstalledDay(string installedDate)
        {
            DateTime installedDt = DateTime.ParseExact(installedDate, DateFormat, CultureInfo.InvariantCulture);

            return installedDt.DayOfWeek.ToString();
        }

        public static void Main(string[] args)
        {
            Program conTvApp = new Program();


            Console.WriteLine("Enter the expected date");
            string expectedDateInput = Console.ReadLine();

            Console.WriteLine("Enter the installed date");
            string installedDateInput = Console.ReadLine();

            string installedDay = conTvApp.FindTheInstalledDay(installedDateInput);
            Console.WriteLine($"Installed day : {installedDay}");

            string customerFeedback = conTvApp.CustomerFeedback(expectedDateInput, installedDateInput);
            Console.WriteLine($"Customer feedback : {customerFeedback}");
        }
    }
}