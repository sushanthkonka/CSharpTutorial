using System;

abstract class Payment
{
    
    public abstract void ProcessPayment();
    public void Authenticate()
    {
        Console.WriteLine("User authenticated.");
    }
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

class UpiPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing UPI payment...");
    }
}

class Abstraction
{
    public static void PaymentMethod()
    {
        Payment payment;

        payment = new CreditCardPayment();
        payment.Authenticate();
        payment.ProcessPayment();

        Console.WriteLine();

        payment = new UpiPayment();
        payment.Authenticate();
        payment.ProcessPayment();
    }
}
