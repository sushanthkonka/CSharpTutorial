
internal static class StringOperations
{
    public  static string String_Concatenation( )
    {
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

public static char String_Access()
{
    string name = "John";
    char name1 = name[1];
    return name1;
}

 public static string Special_Characters()
{
    string txt = "We are the so-called \"Vikings\" from the north.";
    return txt;
}

    
}