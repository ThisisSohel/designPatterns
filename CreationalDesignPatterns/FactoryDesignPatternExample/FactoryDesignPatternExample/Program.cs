using FactoryDesignPatternExample.FactoryClasses;
using FactoryDesignPatternExample.Interfaces;

namespace FactoryDesignPatternExample
{
    //Here is the client code.
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = PaymentFactory.GetPayment("PayPal");
            payment.ProcessPayment();

            Console.Write("Enter notification type (Email/SMS/Push): ");
            string type = Console.ReadLine();

            try
            {
                INotification notification = NotificationFactory.CreateNotification(type);
                notification.Send("Hello! This is a factory pattern example.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
