using System;
using System.Text;
using System.Linq;


namespace PalindromeProgram
{
    class MainProgram
    {
        
        static void Main(string[] args)
        {
            
            Palindrome palindrome = new Palindrome();

            var input = "";
            var output = "";
            Console.WriteLine("######## Welcome to Palindrome checker program ########");
            while (!input.Contains("exit"))
            {              
                
               input = palindrome.GetUserInput();

                if (!(input.Length > 1))
                {
                    Console.WriteLine(input + " is too short. Enter a word or number that is longer than one character." + "\n");
                }
                else
                {
                    if (!input.Contains("exit"))
                    {
                        // Should return the reverse of "input" and place it in a variable "output"
                        output = palindrome.ReverseString(input);

                        // shows the users input and the reverse of input which is in output
                        palindrome.Show_Strings(input, output);

                        // check if input is a palindrome
                        palindrome.CheckResult(output);
                        
                    }

                }
            }
        }

    }

    

}