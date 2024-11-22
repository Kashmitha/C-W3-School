using System;

class Program
{
    enum Level{
        Small,
        M,
        Large
    }
    static void Main(string[] args)
    {
        Level myVar = Level.M;
        Console.WriteLine(myVar);
    }
}