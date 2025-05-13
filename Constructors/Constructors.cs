using System;

internal class Pen
{
    public string color;

    public Pen()
    {
       color  = "Red";
    }
}

internal static class Constructors
{
    public static void ShowPenColor()
    {
        Pen myPen = new Pen();  
        Console.WriteLine(myPen.color);  
    }
}