using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is planning and supervising.");
    }
}

class Polymorphism
{
    public static void Method_Overriding()
    {
        Employee emp1 = new Employee();
        Employee emp2 = new Manager();

        emp1.Work();  
        emp2.Work();  
    }
}



// class MathOperations
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public double Add(double a, double b)
//     {
//         return a + b;
//     }

//     public int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MathOperations obj = new MathOperations();
//         Console.WriteLine(obj.Add(2, 3));        
//         Console.WriteLine(obj.Add(2.5, 3.5));    
//         Console.WriteLine(obj.Add(1, 2, 3));     
//     }
// }
