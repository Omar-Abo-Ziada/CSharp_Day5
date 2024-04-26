using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    internal class Pigeon : Bird
    {
        //public override int Age { get; set; }
        public Pigeon(int age)
        {
            Age = age;
        }
        public override void Die()
        {
            base.Die();
        }
        public override string ToString()
        {
            return $"I am a Pigeon and my Age is : {Age}";
        }
    }
}
