using System;
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine($"{myCar.brand} {myCar.modelName}");
    }
}