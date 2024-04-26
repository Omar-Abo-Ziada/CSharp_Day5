using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    //public delegate void AnimalDied(object sender, Args args);
    public delegate void AnimalDied<T1, T2>(T1 sender, T2 args);
    public  abstract class Animal
    {
        //public event Action<object, Args> AnimalDied;
        //public AnimalDied AnimalDied { get; set; }
        //==================================
        public AnimalDied<Animal, Args> AnimalDied ;
        //==================================
        //public delegate void AnimalDied(object sender, Args args);
        //public delegate void AnimalDied<T1,T2>(T1 sender, T2 args);
        public int Age { get; set; }
        public virtual void Die()
        {
            if (AnimalDied != null)
            {
                AnimalDied(this, new Args() { ExtraMessage = "Hello from Args ..." });
            }
            //AnimalDied?.Invoke(this, new Args() { ExtraMessage = "Hello from Args ..." });
        }
    }
    public class Args
    {
        // any extra info u would like to send in the future ... 
        internal string ExtraMessage { get; set; }
    }
}
