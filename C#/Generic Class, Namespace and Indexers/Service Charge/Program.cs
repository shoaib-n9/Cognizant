//Implement the namespace here 
using System;
using ServiceCharge;

namespace UserInterface //Do NOT change the namespace name
{
    public class Program    //Do NOT change the class name
    {
        //Implement your method here

        public double ServiceChargeCalculation(Service service)
        {
            if (service.Category != "Mobile" && service.Category != "Laptop")
            {
                return 0;
            }

            double discountedCost = service.Cost;

            if (service.TokenNumber >= 1 && service.TokenNumber <= 10)
            {
                discountedCost *= 0.50;
            }
            else if (service.TokenNumber >= 11 && service.TokenNumber <= 20)
            {
                discountedCost *= 0.75;
            }
            else if (service.TokenNumber >= 21 && service.TokenNumber <= 30)
            {
                discountedCost *= 0.90;
            }

            return discountedCost;
        }

        public static void Main(string[] args)
        {
            //Implement your code here 

            Program programInstance = new Program();

            Service service = new Service();

            Console.WriteLine("Enter the category");
            service.Category = Console.ReadLine();

            Console.WriteLine("Enter the token number");
            int tokenNumberInput;
            if (!int.TryParse(Console.ReadLine(), out tokenNumberInput))
            {
                Console.WriteLine("Invalid token number. Please enter an integer.");
                return;
            }
            service.TokenNumber = tokenNumberInput;

            Console.WriteLine("Enter the service cost");
            double serviceCostInput;
            if (!double.TryParse(Console.ReadLine(), out serviceCostInput))
            {
                Console.WriteLine("Invalid service cost. Please enter a number.");
                return;
            }
            service.Cost = serviceCostInput;

            double finalCost = programInstance.ServiceChargeCalculation(service);

            if (finalCost == 0 && (service.Category != "Mobile" && service.Category != "Laptop"))
            {
                Console.WriteLine("Invalid category");
            }
            else
            {
                Console.WriteLine($"After the discount, the total cost of service for your {service.Category} is ${finalCost}");
            }
        }
    }
}