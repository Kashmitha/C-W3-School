using System;

class Person{
    public string Name { get; set; }
    public int Age { get; set; }

    static void Main(string[] args){
        Person person= new Person("Alice",30);
        Animal animal= new Animal();
        Animal dog= new Dog();
        Console.WriteLine($"{person.Name} {person.Age}");
        animal.MakeSound();
        dog.MakeSound();
    }
    class Animal{
        public virtual void MakeSound(){
            Console.WriteLine("Dogs make sounds");
        }
    }
    class Dog : Animal{
        public override void MakeSound(){
            Console.WriteLine("Dogs make sounds like a bow wow");
        }
    }
    class Car{
        private string model;
        public string Model{
            get{ return model;}
            set{ model = value;}
        }
    }
    public Person(string personName, int age){
        this.Name = personName;
        this.Age = age;
    }
    
}
