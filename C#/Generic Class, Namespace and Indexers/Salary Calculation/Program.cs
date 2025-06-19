using System;
using System.Collections.Generic;

namespace SalaryCalculation //Do NOT change the namespace name
{
    public class Program    //Do NOT change the class name
    {
        public static List<Employee<string>> employeeList = new List<Employee<string>>()
        {
            new Employee<string>() { Id=180315, Name="Rosy",  DOB="10/07/1999"},
            new Employee<string>() { Id=180316, Name="David", DOB="05/03/1998" },
            new Employee<string>() { Id=180317, Name="Peter", DOB="12/12/2000"}
        };

        public static void Main(string[] args)
        {
            //Implement your code here 

            Employee<string> currentEmployee = new Employee<string>();


            Console.WriteLine("Enter the user name");
            int userIdInput;
            if (!int.TryParse(Console.ReadLine(), out userIdInput))
            {
                Console.WriteLine("Invalid user name. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter the password");
            string userPasswordInput = Console.ReadLine();

            bool isValidUser = Employee<string>.UsernamePasswordChecking(userIdInput, userPasswordInput, employeeList);

            if (isValidUser)
            {
                Console.WriteLine("Enter the basic pay");
                double basicPayInput;
                if (!double.TryParse(Console.ReadLine(), out basicPayInput))
                {
                    Console.WriteLine("Invalid basic pay. Please enter a number.");
                    return;
                }

                string employeeNameForOutput = "";
                foreach (var emp in employeeList)
                {
                    if (emp.Id == userIdInput && emp.DOB.Equals(userPasswordInput, StringComparison.Ordinal))
                    {
                        employeeNameForOutput = emp.Name;
                        break;
                    }
                }

                currentEmployee.Id = userIdInput;
                currentEmployee.Name = employeeNameForOutput;
                currentEmployee.DOB = userPasswordInput;


                double totalSalary = currentEmployee.SalaryCalculation(basicPayInput);

                Console.WriteLine($"The employee's total salary is {totalSalary}");
            }
            else
            {
                Console.WriteLine("Invalid user name or password");
            }

        }
    }
}