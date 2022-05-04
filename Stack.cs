using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class Stack
    {
        public List<object> StackArray { get; set; } = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
            StackArray.Insert(0,obj);
        }

        public object Pop()
        {
            if (StackArray[0] == null)
                throw new InvalidOperationException("test");

            object obj = StackArray.FirstOrDefault();
            StackArray.RemoveAt(0);
            return obj;
            
        }

        public void Clear()
        {
            StackArray.Clear();
        }

        
    }
}