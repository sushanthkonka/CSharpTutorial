internal static class Condition_While
{
    public static string PrintNumbersWithWhile(int i)
    {
        string result = "";

        while (i < 5)
        {
            result += i + " ";
            i++;
        }

        return result; 
    }
}
