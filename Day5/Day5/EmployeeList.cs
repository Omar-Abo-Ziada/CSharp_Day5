using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class EmployeeList : MyList<Employee>
    {
        public Employee this[string name]
        {
            get 
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Name == name)
                        return items[i];
                }
                return null;
            }
        }
    }
}
