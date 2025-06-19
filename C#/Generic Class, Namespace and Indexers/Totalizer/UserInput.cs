using System;

namespace IndexerExample //DO NOT change the namespace name
{
    public class UserInput //DO NOT change the class name
    {
        //Implement your code here
        private int[] values = new int[5];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < values.Length)
                {
                    return values[index];
                }
                else
                {
                    return values[index];
                }
            }
            set
            {
                if (index >= 0 && index < values.Length)
                {
                    values[index] = value;
                }
                else
                {
                }
            }
        }

        public int Sum()
        {
            int totalSum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                totalSum += values[i];
            }
            return totalSum;
        }
    }
}