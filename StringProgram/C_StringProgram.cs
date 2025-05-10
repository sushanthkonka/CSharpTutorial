
internal static class C_StringProgram
{
    public  static string String_Assign( )
    {
        // string greeting = "Hello";
        // return greeting;
        string firstName = "John ";
        string lastName = "Doe";
        string name = firstName + lastName;
        return name;
      
    }

    public  static string String_Interpolation( )
    {
         string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      return name;
      
    }

  public static string String_Access()
{
    string name = "John";
    char name1 = name[1]; 
    
    return name1.ToString(); 
}

 public static string String_Text()
{
    string txt = "We are the so-called \"Vikings\" from the north.";
    return txt;
}

    
}