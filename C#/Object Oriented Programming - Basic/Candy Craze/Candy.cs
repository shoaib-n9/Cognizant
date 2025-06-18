using System;

namespace CandyCraze //DO NOT change the namespace name
{
    public class Candy //DO NOT change the class name
    {
        //Implement your code here
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }

        public bool ValidateCandyFlavour()
        {

            if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}