using System;
using System.ServiceModel;

namespace PalindromeService
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IPalindrome
    {
        [OperationContract]
        bool IsPalindrome(string word);

    }
}