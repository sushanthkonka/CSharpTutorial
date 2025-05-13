using System;

namespace MyApplication
{
  class Try_Catch  {
    public static void ExceptionHandling()
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception)
      {
        Console.WriteLine("Something went wrong.");
      }  
      finally
      {
        Console.WriteLine("The 'try catch' is finished.");
      }  
    }
  }
}