using System;

class Vehicle
{
    public virtual void Car()
    {
        Console.WriteLine("Which car?");
    }
}

class Tesla : Vehicle
{
    public override void Car()
    {
        Console.WriteLine("Tesla Dami Xa");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Tesla T = new Tesla();
        T.Car();
    }
}