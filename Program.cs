namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPaymentProcessor> payments = new List<IPaymentProcessor>
            {
                new CreditCardPayment(),
                new PayPalPayment(),
                new BitcoinPayment(),
                new CashPayment()
            };

            foreach (var payment in payments)
            {
                payment.ProcessPayment(200);  // Process payment of 200 for each method
            }
        }
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    // Implementing Credit Card Payment
    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    // Implementing PayPal Payment
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }

    // Implementing Bitcoin Payment
    public class BitcoinPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
        }
    }

    // Implementing Cash Payment
    public class CashPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing cash payment of {amount:C}");
        }
    }



}
