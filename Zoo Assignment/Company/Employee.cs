using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company
{
    enum Gender
    {
        male = 1, female = 2
    }
    internal class Employee : Person, IPlayable
    {
        public Action<Employee, Args> SalaryIncreaseDelegate ;
        public Predicate<Employee> FilterDelegate ;
        public string NID { get; set; }
        //public string Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public Employee(string nid, string name, decimal salary, Gender gender) : this()
        {
            NID = nid;
            Name = name;
            Salary = salary;
            Gender = gender;
        }
        public Employee(string nid, Gender gender) : this()
        {
            NID = nid;
            Gender = gender;
        }
        public Employee()
        {
            NID = default;
            Name = default;
            Salary = default;
            Gender = Gender.male;

            if (FilterDelegate != null)
            {
                FilterDelegate(this);
            }
    }
        public decimal ShowPayment()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"\nNID is : {NID} \t Name : {Name} \t Salary : {Salary}";
        }
        public void IncreaseSalary(decimal increaseAmount)
        {
            Salary += increaseAmount;

            if (SalaryIncreaseDelegate != null)
            {
                SalaryIncreaseDelegate(this, new Args() { IncreasmentAmount = increaseAmount });
            }
        }
    }
    internal class Args
    {
        internal string ArgsMessage { get; set; }
        internal decimal IncreasmentAmount { get; set; }
    }
}
