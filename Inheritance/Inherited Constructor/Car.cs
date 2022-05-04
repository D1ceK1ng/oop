using System;

namespace OOP.Inheritance.Inherited_Constructor
{
    public class Car : Vehicle
    {
        //public Car()
        //{
        //    Console.WriteLine("Car goes brrrr...");
        //}
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine(registrationNumber);
        }
    }
}