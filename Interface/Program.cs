using System;

interface IAnimal
{
    void animalSound();
}
class Pig : IAnimal{
    public void animalSound(){
        Console.WriteLine("Pig Says Wee Wee");
    }
}
public static class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}