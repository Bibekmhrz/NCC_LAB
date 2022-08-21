using System;
namespace Inheritance
{
    //base class
    class Vehicle
    {
        public string name;
        public void display()
        {
            Console.WriteLine("Which vehicle do you like?");
        }
    }
    // derived class of an Animal
    class Car:Vehicle
    {
        public void getName()
        {
            Console.WriteLine($"I like {name}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of derived class
            Car Tesla = new Car();
            //access field and method of base class
            Tesla.name = "Black Tesla";
            Tesla.display();
            //access method from own class
            Tesla.getName();
            Console.ReadLine();
        }
    }
}