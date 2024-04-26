using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Assignment
{ 
    internal class PhoneBook 
    {    
        //inner struct so it can be used only inside the class
        struct Pair
        {
            internal int number;
            internal string name;
        }

        private List<Pair> pairs;
        public string this[int numberInput]
        {
            get
            {
                for (int i = 0; i < pairs.Count; i++)
                {
                    if (pairs[i].number == numberInput)
                    {
                        return pairs[i].name;
                    }
                }
               // return null;
                throw new Exception("can't find this number attached to any person ! ");
            }
            set
            {
                Pair pair = new Pair() { number = numberInput , name = value };
                pairs.Add(pair);
            }
        }
        public int this[string nameInput]
        {
            get
            {
                for (int i = 0; i < pairs.Count; i++)
                {
                    if (pairs[i].name == nameInput)
                    {
                        return pairs[i].number;
                    }
                }
                //return 0 ;
                throw new Exception("can't find a person with this name ! ");
            }
            set
            {
                Pair pair = new Pair() { name = nameInput , number = value};
                pairs.Add(pair);
            }
        }
        public PhoneBook()
        {
            pairs = new List<Pair>() ;
        }
    }
}
