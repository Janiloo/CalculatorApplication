using System;

namespace CalculatorApplication
{
    // Declare a generic delegate named Formula
    public delegate T Formula<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        // Event that uses the delegate
        public event Formula<double> CalculateEvent;

        // Methods for arithmetic operations

        // Method to get the sum of two numbers
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method to get the difference of two numbers
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method to get the product of two numbers
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        // Method to get the quotient of two numbers
        public double GetQuotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return num1 / num2;
        }
    }
}