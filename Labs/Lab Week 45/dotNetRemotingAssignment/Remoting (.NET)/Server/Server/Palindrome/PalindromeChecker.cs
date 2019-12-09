using System;
using System.Linq;
using System.Text;

namespace Server
{
    public class PalindromeChecker : MarshalByRefObject, IPalindromeChecker
    {
        public Boolean isPalindrome(string word)
        {
            return word.Equals(ReverseString(word), StringComparison.InvariantCultureIgnoreCase);
        }

        private string ReverseString(string users_input)
        {
            var newstr = new StringBuilder();
            Stack s = new Stack();

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
    }
}
