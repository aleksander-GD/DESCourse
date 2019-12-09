using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GettingStartedClient.CalculatorService;
using GettingStartedClient.PalindromeRef;

namespace GettingStartedClient
{
    public class Program
    {
  
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.
            CalculatorClient client = new CalculatorClient();
            PalindromeClient palClient = new PalindromeClient();


            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Please enter the number for the mathematical:");
            Console.WriteLine("While entering numbers please type the first number and then use enter to type the next number");
            int menuchoice = 0;
            while (menuchoice != 7)
            {

                //Console.WriteLine("Simple Calculator");
                //Console.WriteLine("Please enter the number for the mathematical:");
                //Console.WriteLine("While entering numbers please type the first number and then use enter to type the next number");
                Console.WriteLine();
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Check if prime");
                Console.WriteLine("6. Check if word is palindrome");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("Enter 2 numbers to add: ");
                        Console.WriteLine("Value 1");
                        string addValue1 = Console.ReadLine();
                        Console.WriteLine("Value 2");
                        string addValue2 = Console.ReadLine();
                        double addResult = client.Add(double.Parse(addValue1), double.Parse(addValue2));
                        Console.WriteLine("Add({0},{1}) = {2}", addValue1, addValue2, addResult);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter 2 numbers to subtract: ");
                        Console.WriteLine("Value 1");
                        string subValue1 = Console.ReadLine();
                        Console.WriteLine("Value 2");
                        string subValue2 = Console.ReadLine();
                        double subResult = client.Subtract(double.Parse(subValue1), double.Parse(subValue2));
                        Console.WriteLine("Subtract({0},{1}) = {2}", subValue1, subValue2, subResult);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter 2 numbers to multiply: ");
                        Console.WriteLine("Value 1");
                        string mulValue1 = Console.ReadLine();
                        Console.WriteLine("Value 2");
                        string mulValue2 = Console.ReadLine();
                        double mulResult = client.Multiply(double.Parse(mulValue1), double.Parse(mulValue2));
                        Console.WriteLine("Multiply({0},{1}) = {2}", mulValue1, mulValue2, mulResult);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter 2 numbers to divide: ");
                        Console.WriteLine("Value 1");
                        string divValue1 = Console.ReadLine();
                        Console.WriteLine("Value 2");
                        string divValue2 = Console.ReadLine();
                        double divResult = client.Divide(double.Parse(divValue1), double.Parse(divValue2));
                        Console.WriteLine("Divide({0},{1}) = {2}", divValue1, divValue2, divResult);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter a number to check if it is prime: ");
                        string primeValue1 = Console.ReadLine();

                        bool primeCheck = client.IsPrime(int.Parse(primeValue1));
                        if (primeCheck)
                        {
                            Console.WriteLine("Number {0} is prime", primeValue1);
                            break;
                        }
                        Console.WriteLine("Number {0} is not prime", primeValue1);
                        break;
                    case 6:
                        Console.WriteLine("Enter a word or a number to check if it is a palindrome: ");
                        string word = Console.ReadLine();

                        bool checkPalindrome = palClient.IsPalindrome(word);

                        if (checkPalindrome)
                        {
                            Console.WriteLine("The word or number {0} is palindrome", word);
                            break;
                        }
                        Console.WriteLine("The word or number {0} is NOT palindrome", word);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("You did not enter correct selection");
                        break;
                }
               
            }
        }
    }
}