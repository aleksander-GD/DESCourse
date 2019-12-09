using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class CreditTest
    {
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 12.00;
            double creditAmount = 4.00;
            double expected = 16.00;
            BankAccount account = new BankAccount("Mr. Poul Newton", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Abraham Woodhull", beginningBalance);

            // Act and assert
            try
            {
                account.Credit(creditAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.CreditAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}