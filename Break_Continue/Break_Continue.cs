internal static class Break_Continue
{
    public static void DemonstrateBreakAndContinue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);

        }

        for (int i = 10; i < 20; i++)
        {
            if (i == 14)
            {
                continue;
            }
            Console.WriteLine(i);
        }


    }
}