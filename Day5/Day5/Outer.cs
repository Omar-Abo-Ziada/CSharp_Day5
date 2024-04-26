using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Outer
    {
        int x;

        public Outer() 
        {
        }

        class Nested
        {
            int y;

            public Nested() 
            {
               Outer outer = new Outer();

                outer.x = 10;
            }

        }
    }
}
