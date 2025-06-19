using System;

// DO NOT change the namespace name
namespace SalaryCalculation
{
    public class Employee<Y> where Y : class
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DOB { get; set; }

        public bool UsernamePasswordChecking<T>(T empIdInput, Y empDOBInput)
        {
            int employeeIdInt;
            if (!int.TryParse(empIdInput.ToString(), out employeeIdInt))
            {
                return false;
            }

            if (this.Id == employeeIdInt && this.DOB.Equals(empDOBInput.ToString(), StringComparison.Ordinal))
            {
                return true;
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
