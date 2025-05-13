using System;
using System.Linq;
using MyApplication;
internal class Program
{
    private static void Main(string[] args)
    {
        //Hello World 
        Console.WriteLine("Hello, World!");
        System.Console.WriteLine();

        //Square root of a Number 
        System.Console.WriteLine("Square root of a Number 4 is :");
        Console.WriteLine(MathProgram.SquareRootOfNum(4));
        System.Console.WriteLine();

       // Concatanation of a string
       System.Console.WriteLine("Concatanation of a string");
        Console.WriteLine(StringOperations.String_Concatenation());
        System.Console.WriteLine();

        //Interpolation 
        System.Console.WriteLine("Interpolation of a String:");
        Console.WriteLine(StringOperations.String_Interpolation());
        System.Console.WriteLine();
      
       //Accessing the index of a string
        System.Console.WriteLine(" Accessing the character at index '0': ");
        Console.WriteLine(StringOperations.String_Access());
        System.Console.WriteLine();

       //Printing of Special Characters
       System.Console.WriteLine("Printing of Special Characters :");
        Console.WriteLine(StringOperations.Special_Characters());
        System.Console.WriteLine();


       // Boolean for a statement
       System.Console.WriteLine("Is Csharp Fun:?");
        Console.WriteLine(BooleanProgram.IsCSharpFun());
        System.Console.WriteLine("Is Fist Tasty:?");
        Console.WriteLine(BooleanProgram.IsFishTasty());
        System.Console.WriteLine();

        //Using If else for comparing numbers
        System.Console.WriteLine("Comparing numbers by using if else:");
        Console.WriteLine(Conditions.CompareNumbers(3, 4));
        System.Console.WriteLine();

        //Switch Condition for weekday
        System.Console.WriteLine("Switch condition for Weekday 5:");
        Console.WriteLine(SwitchCondition.Weekday(5));
        System.Console.WriteLine();
         
        //while statement for printing numbers 
        System.Console.WriteLine("Print numbers from 0 to 5: ");
        Console.WriteLine(Condition_While.PrintNumbersWithWhile(0));
        System.Console.WriteLine();

        //Method
        System.Console.WriteLine("Addition using method return value:");
        System.Console.WriteLine(Methods.MyMethod_ReturnValues(4));
        System.Console.WriteLine();

        //For Loop
        System.Console.WriteLine("Printing items in a string by using For Loop :");
        LoopExample.ForLoop();
        System.Console.WriteLine();

        //Break and Continue
        System.Console.WriteLine("Skip the number and continue:");
        Break_Continue.DemonstrateBreakAndContinue();
        System.Console.WriteLine();


       //Changing the Array element by using index value
        System.Console.WriteLine("Changing the Array element by using index value:");
        ArrayExamples.Array_Element();
        System.Console.WriteLine();

       //Length of an array
       System.Console.WriteLine("Length of an array:");
        ArrayExamples.Array_Length();
        System.Console.WriteLine();

        //Sorting elemnets in an Array
        System.Console.WriteLine("Sorting the elements in an array Alphabetical wise:");
        ArrayExamples.Array_Sort();
        System.Console.WriteLine();

        //Method Overloading
        System.Console.WriteLine("Adding integer and decimal vales by same method:");
        Method_Overloading.PlusMethodInt(8, 5);
        Method_Overloading.PlusMethodDouble(4.3, 6.26);
        System.Console.WriteLine();

        //class Object
        System.Console.WriteLine("Color of the car:");
        Class_Object.ShowCarColor();
        System.Console.WriteLine();

        //Constructor
        System.Console.WriteLine("Color of a pen:");
        Constructors.ShowPenColor();
        System.Console.WriteLine();

        //Encapsulation
        System.Console.WriteLine("Age of a person by Getter Setter:");
        Encapsulation.AgeOfPerson();
        System.Console.WriteLine();

        //Ineritance
        System.Console.WriteLine("Behavior of a animal:");
        Inheritance.AnimalBehavior();
        System.Console.WriteLine();

        //Polymorphism
        System.Console.WriteLine("Methor Overriding:");
        Polymorphism.Method_Overriding();
        System.Console.WriteLine();

        //Abstraction
        System.Console.WriteLine("Payment method by using abstract class:");
        Abstraction.PaymentMethod();
        System.Console.WriteLine();

        //Try Catch Finally
        System.Console.WriteLine("Exception Handing by Try Catch and Finally:");
        Try_Catch.ExceptionHandling();
        System.Console.WriteLine();
      


    }
}

