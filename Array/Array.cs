using System;
using System.Linq;
internal static class ArrayExamples
{
    public static void Array_Element()
    {

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        cars[0] = "Opel";
        Console.WriteLine(cars[0]);
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

    }
    public static void Array_Length()
    {

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars.Length);

    }

    public static void Array_Loop()
    {

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(cars[i]);
        }

    }

    public static void Array_Sort()
    {

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Array.Sort(cars);
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }

        int[] myNumbers = { 5, 1, 8, 9 };
        Array.Sort(myNumbers);
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);

        }

    }

    public static void Array_MultiDimentional()
    {

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[0, 2]);

    }
}