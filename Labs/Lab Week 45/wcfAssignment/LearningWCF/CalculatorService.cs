using System;
using System.Linq;
using System.ServiceModel;

namespace LearningWCF
{
    public class CalculatorService : ICalculator
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Received Add({0},{1})", n1, n2);
            // Code added to write output to the console window.
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Received Subtract({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Received Multiply({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Received Divide({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
        public bool IsPrime(int n)
        {
            Console.WriteLine("Received {0}", n);
            bool checkPrime = false;
            // Corner case 
            if (n <= 1) {
                Console.WriteLine("Return: {0}", checkPrime);
                return checkPrime;
            }

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { 
                    Console.WriteLine("Return: {0}", checkPrime);
                    return checkPrime;
                }
            }
            checkPrime = true;
            Console.WriteLine("Return: {0}", checkPrime);
            return checkPrime;
        }

        //public bool IsPalindrome(string word)
        //{
        //    //first reverse the string
        //    string reversedString = new string(word.Reverse().ToArray());
        //    return string.Compare(word, reversedString) == 0 ? true : false;
        //}
    }
}