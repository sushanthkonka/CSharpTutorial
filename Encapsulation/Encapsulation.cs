public class Person
{
    private int age;  
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 150) 
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a value between 0 and 150.");
            }
        }
    }
}

class Encapsulation
{
    public static void AgeOfPerson()
    {
        Person p = new Person();

        p.Age = -5;  
        Console.WriteLine(p.Age);  

        p.Age = 25;
        Console.WriteLine(p.Age);  
    }
}
