using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    internal class Elephant : Mammal
    {
        //public override int Age { get; set; }

        public Elephant(int age)
        {
            Age = age;
        }
        public override void Die()
        {
            base.Die();
        }
        public override string ToString()
        {
            return $"I am an Elephant and my Age is : {Age}";
        }
    }
}
