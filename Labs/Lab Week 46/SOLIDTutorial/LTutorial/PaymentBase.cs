using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTutorial
{
    public abstract class PaymentBase
    {
        public abstract bool Refund(decimal amount, string transactionId);
    }
    //public abstract class PaymentBase
    //{
    //    public abstract string Refund(decimal amount, string transactionId);
    //}
}
