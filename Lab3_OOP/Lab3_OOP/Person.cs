using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    public class Person
    {
        public int Age { get; set; }
        public string City { get; set; }
        public string Name { get; set; }

        public virtual string GetDescription()
        {
            return $"Name: {Name} City: {City} Age: {Age}";
        }
    }
}
