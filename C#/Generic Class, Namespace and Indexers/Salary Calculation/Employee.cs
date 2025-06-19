using System;

// DO NOT change the namespace name
namespace SalaryCalculation
{
    public class Employee<Y> where Y : class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Y DOB { get; set; }

        public static bool UsernamePasswordChecking<T>(T empId, Y empDOB, List<Employee<Y>> masterEmployeeList)
        {
            int employeeIdInt;
            if (!int.TryParse(empId.ToString(), out employeeIdInt))
            {
                return false;
            }

            foreach (var emp in masterEmployeeList)
            {
                if (emp.Id == employeeIdInt && emp.DOB.ToString().Equals(empDOB.ToString(), StringComparison.Ordinal))
                {
                    return true;
                }
            }
            return false;
        }


        public double SalaryCalculation(double basicPay)
        {
            double daAllowance = 0.40 * basicPay;
            double hrAllowance = 0.20 * basicPay;

            double totalSalary = basicPay + hrAllowance + daAllowance;
            return totalSalary;
        }
    }
}