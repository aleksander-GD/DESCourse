using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STutorial.SRP
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
    public interface IPaymentService
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount);
    }
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(ShoppingCart cart);
    }
}
