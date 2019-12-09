using System;
using System.Linq;
using System.ServiceModel;

namespace PalindromeService
{
    public class PalindromeServiceFUCKER : IPalindrome
    {
        public bool IsPalindrome(string word)
        {
            Console.WriteLine("Received {0}", word);
            //first reverse the string
            string reversedString = new string(word.Reverse().ToArray());
            bool isFuckerTrueOrFalse = string.Compare(word, reversedString) == 0 ? true : false;
            Console.WriteLine("Return: {0}", isFuckerTrueOrFalse);
            return isFuckerTrueOrFalse;
        }
    }
}