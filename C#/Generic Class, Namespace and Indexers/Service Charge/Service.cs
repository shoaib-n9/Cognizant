using System;

namespace ServiceCharge //Do NOT change the namespace name
{
    public class Service    //Do NOT change the class name
    {
        //Implement your code here

        public string Category { get; set; }
        public int TokenNumber { get; set; }
        public double Cost { get; set; }

        public Service()
        {
            Category = string.Empty;
            TokenNumber = 0;
            Cost = 0.0;
        }
    }
}