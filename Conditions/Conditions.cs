internal static class Conditions
{
    public static String CompareNumbers(int a, int b)
    {
         if (a > b)
        {
            return $"{a} is greater than {b}";
        }
      else if (a < b)
        {
            return $"{a} is less than {b}";
        }
        else
        {
            return $"{a} is equal to {b}";
        }
    }
}

