using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    internal class Lion : Mammal
    {
        //public override int Age { get; set; }
        public Lion(int age)
        {
            Age = age;
            //this.Age = age; 
        }
        public override void Die()
        {
            base.Die();
        }
        public override string ToString()
        {
            return $"I am a Lion and my Age is : {this.Age}";
        }
    }
    
}
