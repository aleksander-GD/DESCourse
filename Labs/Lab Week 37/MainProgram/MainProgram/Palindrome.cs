using System;
using System.Linq;
using System.Text;
using StackInterface;


namespace PalindromeProgram
{
    
    public class Palindrome
        
    {
        public Palindrome()
        {

        }
        /// <summary>
        /// Method to get the user input
        /// </summary>
        /// <returns> Returns string based on the user input </returns>
        public string GetUserInput()
        {
            Console.Write("Enter a string (or exit to quit): ");
            string userInput = Console.ReadLine();
            Console.Write("\n");
            return userInput;

        }

        /// <summary>
        /// Show strings of the input and the reverse
        /// </summary>
        /// <param name="input"> Input of type string </param>
        /// <param name="reverse"> Reverse of type string</param>
        public void Show_Strings(string input, string reverse)
        {
            Console.WriteLine("Your input string is: " + input);
            Console.WriteLine("The reverse is: " + reverse);
        }

        /// <summary>
        /// Reverses the String of the user input using a stack
        /// </summary>
        /// <param name="users_input"> Users input of type string </param>
        /// <returns> Returns the reversed string </returns>
        public string ReverseString(string users_input)
        {
            // This method should return the reverse of the users input
            // e.g., user enters "BEST", the reverse should be "TSEB"

            var newstr = new StringBuilder();
            IStack s = new StackImplementation();

            foreach (var c in users_input.ToArray())
            {    
                s.Push(c);
            }

            while (s.Size() > 0)
            {
                
                newstr.Append(s.Pop());
            }

            return newstr.ToString();
        }

        /// <summary>
        /// Check the result of the input if it is palindrome or not
        /// </summary>
        /// <param name="input"> Input to be checked if palindrome or not </param>
        public void CheckResult(string input)
        {
            
            if (!IsPalindrome(input))
            {
                Console.WriteLine("Input: '{0}' is not a Palindrome \n", input);
            }
            else
            {
                Console.WriteLine("Input: '{0}' is a Palindrome \n", input);
            }
        }

        /// <summary>
        /// Method to check the string value if it is palindrome or not.
        /// </summary>
        /// <param name="str"> String to be tested </param>
        /// <returns> Returns true if it is palindrome, false otherwise </returns>
        public bool IsPalindrome(string str)
        {
          
            string first = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}

