using System;

class Vehicle{
    public virtual void vehicleSound(){
        Console.WriteLine("Vehicle makes sounds");
    }
}
class Bus : Vehicle{
    public override void vehicleSound(){
        Console.WriteLine("Bus make sound like braaaaaaa....");
    }
}
class Bike : Vehicle{
    public override void vehicleSound()
    {
        Console.WriteLine("Bike make sound like pata pata pata...");
    }
}
class Program{
    static void Main(string[] args)
    {
        Vehicle v = new Vehicle();
        Vehicle bus = new Bus();
        Vehicle bike = new Bike();

        v.vehicleSound();
        bus.vehicleSound();
        bike.vehicleSound();
    }
}