using System;

abstract class Animal
{
    public string Name{ get; set; } 

    public abstract void makeSound();

    public void sleep(){
        Console.WriteLine($"{Name} is sleeping");
    } 

    class Dog : Animal{
        public override void makeSound(){
            Console.WriteLine($"{Name} makes sound woof");
        }
    }
    class Cat : Animal{
        public override void makeSound()
        {
            Console.WriteLine($"{Name} make sound meow");
        }
    }
    class AnimalSounds
    {
        public static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myCat.Name = "Pussy";
            myDog.Name = "Alpha";

            myCat.sleep();
            myDog.sleep();
            myCat.makeSound();
            myDog.makeSound();
        }
    }
}