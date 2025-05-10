internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(MathProgram.Increment(4));
        Console.WriteLine(C_StringProgram.String_Assign());
        Console.WriteLine(C_StringProgram.String_Interpolation());
        Console.WriteLine(C_StringProgram.String_Access());
        Console.WriteLine(C_StringProgram.String_Text());
    }
}

