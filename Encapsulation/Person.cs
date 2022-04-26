using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
            
        }

        
    }
}
