using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
   public static void Main(string[] args)
   {
      string str1 = "Hello";
      string str2 = "hello";

      Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
      
   }
}    