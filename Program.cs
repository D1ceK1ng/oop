using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OOP 
{
    internal class Program
    {
        public static void Main()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        
    }
}