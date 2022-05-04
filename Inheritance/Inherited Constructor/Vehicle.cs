using System;

namespace OOP.Inheritance.Inherited_Constructor
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle goes brrrr...");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine(registrationNumber);
        }
    }
}