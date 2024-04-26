using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Assignment
{
    internal class AdvancedPhoneBook
    {
        Dictionary<string, int> entries;
        public int this[string nameInput]
        {
            get
            {
                foreach (KeyValuePair<string, int> item in entries)
                {
                    if (item.Key == nameInput)
                          return item.Value;
                }
                throw new Exception("can't find this name ! ");
            }
            set
            {
                entries.Add(nameInput, value);

                // ==> Another way using KeyValuePair instance : 
                //KeyValuePair<string, int> newPair = new KeyValuePair<string, int>(nameInput, value);
                //entries.Add(newPair.Key, newPair.Value);
            }
        }
        public string this[int numberInput]
        {
            get
            {
                foreach (KeyValuePair<string, int> item in entries)
                {
                    if (item.Value == numberInput)
                        return item.Key;
                }
                throw new Exception("can't find this number ! ");
            }
            set
            {
                entries.Add(value,numberInput );

                // ==> Another way using KeyValuePair instance : 
                //KeyValuePair<string, int> newPair = new KeyValuePair<string, int>(nameInput, value);
                //entries.Add(newPair.Key , newPair.Value);
            }
        }
        public AdvancedPhoneBook()
        {
            entries = new Dictionary<string, int>();
        }
    }
}
