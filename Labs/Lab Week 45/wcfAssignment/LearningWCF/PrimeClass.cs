using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWCF
{
    public class PrimeClass : IPrime
    {

        public bool isPrime(int n)
        {
            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
