using System;

namespace CandyCraze //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the methods here

        public static Candy CalculateDiscountedPrice(Candy candy)
        {

            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

            double discountPercentage = 0;

            if (candy.Flavour == "Strawberry")
            {
                discountPercentage = 15;
            }
            else if (candy.Flavour == "Lemon")
            {
                discountPercentage = 10;
            }
            else if (candy.Flavour == "Mint")
            {
                discountPercentage = 5;
            }

            candy.Discount = candy.TotalPrice - (candy.TotalPrice * discountPercentage / 100.0);

            return candy;

        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here

            Candy userCandy = new Candy();

            Console.WriteLine("Enter the flavour");
            userCandy.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity");
            userCandy.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per piece");
            userCandy.PricePerPiece = int.Parse(Console.ReadLine());


            if (userCandy.ValidateCandyFlavour())
            {
                Candy discountedCandy = CalculateDiscountedPrice(userCandy);

                Console.WriteLine("\nSample Output : ");
                Console.WriteLine($"Flavour : {discountedCandy.Flavour}");
                Console.WriteLine($"Quantity : {discountedCandy.Quantity}");
                Console.WriteLine($"Price Per Piece : {discountedCandy.PricePerPiece}");
                Console.WriteLine($"Total Price : {discountedCandy.TotalPrice}");
                Console.WriteLine($"Discount Price : {discountedCandy.Discount}");
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }
        }
    }
}