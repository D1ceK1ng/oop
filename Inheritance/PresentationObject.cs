using System;

namespace OOP.Inheritance
{
    public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void Copy()
        {
            Console.WriteLine("Copied to clpboard");

        }

        public void Dublicate()
        {
            Console.WriteLine("Object");
        }

    }
}