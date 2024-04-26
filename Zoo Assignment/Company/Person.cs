using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name = "Unknown", int age = default)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"\nthis person name is : {Name} \t and his age is : {Age}";
        }
    }
}
