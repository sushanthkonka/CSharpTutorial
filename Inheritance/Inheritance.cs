
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}


public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}


public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Inheritance
{
    public static void AnimalBehavior()
    {
        Dog myDog = new Dog();
        myDog.Eat();  
        myDog.Bark();  

        Cat myCat = new Cat();
        myCat.Eat();   
        myCat.Meow();  
    }
}
