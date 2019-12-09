using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTutorial
{
    public class PayPalWebService
    {
        public string GetTransactionToken(string username, string password)
        {
            return "Hello from PayPal";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth";
        }
    }
}
