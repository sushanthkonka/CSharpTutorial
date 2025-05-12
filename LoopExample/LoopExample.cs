internal static class LoopExample
{
    public static void ForLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
    }

    
}