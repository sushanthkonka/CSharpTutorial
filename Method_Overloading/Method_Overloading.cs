
using System.IO.Compression;
using System.IO.Pipelines;

internal static class Method_Overloading
{
   public static void PlusMethodInt(int x, int y)
    {
        int Z;
        Z = x+y;
      Console.WriteLine(Z);
    }

   public static void PlusMethodDouble(double x, double y)
    {
      double Z;
      Z = x+y;
      Console.WriteLine(Z);
    }

}