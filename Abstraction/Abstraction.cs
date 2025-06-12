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
        Payment sushanth = new CreditCardPayment();
        sushanth.Authenticate();
        sushanth.ProcessPayment();

        Console.WriteLine();

       sushanth = new UpiPayment();
        sushanth.Authenticate();
        sushanth.ProcessPayment();
    }
}
