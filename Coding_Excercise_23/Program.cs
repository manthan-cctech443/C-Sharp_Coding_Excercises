using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public interface IPayment
        {
            // TODO: Declare a method ProcessPayment
            public void ProcessPayment();
        }

        public class CreditCardPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment()
            {
                Console.WriteLine("Processing credit card payment");
            }
        }

        public class PayPalPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment()
            {
                Console.WriteLine("Processing PayPal payment");
            }
        }

        
        public static void ProcessPayments()
        {
            // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
            CreditCardPayment CCP = new CreditCardPayment();
            PayPalPayment PPP = new PayPalPayment();
            CCP.ProcessPayment();
            PPP.ProcessPayment();
        }
        

        public static void Main(string[] args)
        {
            ProcessPayments();
        }
    }
}