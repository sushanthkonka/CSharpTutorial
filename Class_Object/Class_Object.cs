using System;

internal class Car
{
    public string color = "red";
}

internal static class Class_Object
{
    public static void ShowCarColor()
    {
        Car myCar = new Car(); 
        Console.WriteLine(myCar.color); 
    }
}


