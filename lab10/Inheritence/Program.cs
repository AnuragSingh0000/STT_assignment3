using System;

// Base class
class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int speed, int fuel)
    {
        this.speed = speed;
        this.fuel = fuel;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }
}

// Derived class Car
class Car : Vehicle
{
    private int passengers;

    public Car(int speed, int fuel, int passengers)
        : base(speed, fuel)
    {
        this.passengers = passengers;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine($"Car is moving with passengers ({passengers})...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
    }
}

// Derived class Truck
class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int speed, int fuel, int cargoWeight)
        : base(speed, fuel)
    {
        this.cargoWeight = cargoWeight;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine($"Truck is moving with cargo ({cargoWeight} kg)...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo Weight: {cargoWeight} kg");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle v = new Vehicle(100, 50);
        Car c = new Car(120, 60, 4);
        Truck t = new Truck(80, 70, 2000);

        Vehicle[] vehicles = { v, c, t };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Drive();
            vehicle.ShowInfo();
            Console.WriteLine();
        }
    }
}
