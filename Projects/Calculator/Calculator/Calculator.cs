using System;

namespace Calculator
{
    public class Calculator
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Subtraction(int first, int second)
        {
            if (first < second)
            {
                throw new ArgumentException("First number is not greater then second");
            }
            return first - second;
        }

    }
}