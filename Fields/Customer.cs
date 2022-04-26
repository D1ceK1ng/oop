﻿using System.Collections.Generic;

namespace OOP.Fields
{
    public class Customer
    {
        public string Name;
        public int Id;
        public readonly List<Order> Order;

        public Customer()
        {
            Order = new List<Order>();
        }
        
        public Customer(int id ) : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;

        }

        public void Promote()
        {   
        }

    }
}
