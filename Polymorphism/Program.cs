using System;

class Animal{
    public virtual void animalSound(){
        Console.WriteLine("Animals make sounds");
    }
}
class Pig : Animal{
    public override void animalSound(){
        Console.WriteLine("Pig makes sound wee wee");
    }
}    
class Dog : Animal{
    public override void animalSound()
    {
        Console.WriteLine("Dog makes sound bow wow");
    }
}

class Program{
    static void Main(string[] args){
        Animal animal = new Animal();
        Animal pig = new Pig();
        Animal dog = new Dog();

        animal.animalSound();
        dog.animalSound();  
        pig.animalSound();
    }
}