using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Choose the patment methodd at a Gas Station 
    //Insert the card 
    //Choose the payment method - credit, debit
    //payment approved,payment error
    //print the receipt 

     abstract class PaymentMethod
     {
        protected float amount;
        protected int transactionID;
        protected string description;

        public abstract void processPayment();
        public abstract void paymentDisplay();
     }

    class Debit : PaymentMethod
    {
        protected int cardNumber, CVV, PIN;
        public override void processPayment()
        {
            Console.WriteLine("Enter the transaction amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the transactionID amount");
            transactionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the transaction description");
            description = (Console.ReadLine());
            Console.WriteLine("Enter the card number");
            cardNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the card CVV number");
            CVV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the card PIN number");
            PIN = Convert.ToInt32(Console.ReadLine());
        }

        public override void paymentDisplay()
        {
            Console.WriteLine("The transaction ID is : {0}", transactionID);
            Console.WriteLine("The transaction amount is: {0}", amount);
            Console.WriteLine("The transaction description is : {0}", description);
        }

    }

    internal class AbstractClassPaymentMethod
    {

        public static void Main(string[] args)
        {
            Debit debit = new Debit();

            debit.processPayment();
            debit.paymentDisplay();
            Console.ReadLine();
        }
    }
}
