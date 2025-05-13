using System;
using System.Linq;
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
        Console.WriteLine(BooleanProgram.Boolean_type());
        Console.WriteLine(BooleanProgram.Boolean_type2());
        Console.WriteLine(Conditions.CompareNumbers(3, 4));
        Console.WriteLine(SwitchCondition.Weekday(5));
        Console.WriteLine(Condition_While.PrintNumbersWithWhile(0));
        LoopExample.ForLoop();
        Break_Continue.DemonstrateBreakAndContinue();
        ArrayExamples.Array_Element();
        ArrayExamples.Array_Length();
        ArrayExamples.Array_Sort();
        Method_Overloading.PlusMethodInt(8, 5);
        Method_Overloading.PlusMethodDouble(4.3, 6.26);
        Class_Object.ShowCarColor();
        Constructors.ShowPenColor();
        Encapsulation.AgeOfPerson();
        Inheritance.AnimalBehavior();
        Polymorphism.Method_Overriding();

    }
}

