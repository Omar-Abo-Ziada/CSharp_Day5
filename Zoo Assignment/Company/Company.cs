using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Company
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public List<Employee> Employees { get; private set; }
        public Company()
        {
            Employees = new List<Employee>();
        }
        public void Add(Employee newEmployee)
        {
            Employees.Add(newEmployee);

            newEmployee.SalaryIncreaseDelegate += this.PaymentIncrease;

            //    newEmployee.FilterDelegate += this.IsMale;
            //    newEmployee.FilterDelegate += this.IsVIP;
        }
        public bool IsMale(Employee emp)
        {
            return emp.Gender == Gender.male;
        }
        public bool IsVIP(Employee emp)
        {
            return emp.Salary > 10_000;
        }
        public void Remove(Employee newEmployee)
        {
            newEmployee.SalaryIncreaseDelegate -= PaymentIncrease;
            Employees.Remove(newEmployee);
        }
        public void Clear()
        {
            //Employees.Clear();
            //Employees.RemoveAll();

            foreach (Employee emp in Employees)
            {
                emp.SalaryIncreaseDelegate -= PaymentIncrease;
                Employees.Remove(emp);
            }
        }
        public void PaymentIncrease(object sender, Args args)
        {
            Employee employee = sender as Employee;

            Console.WriteLine($"The employee {employee.Name} with NID ({employee.NID}) has been raised by : {args.IncreasmentAmount}");

            Budget -= args.IncreasmentAmount;
            Console.WriteLine($"The company current budget is : {Budget} .");
            Console.WriteLine("-----------------------------------------\n");
        }
        public void Filter()
        {
            List<Employee> FilteredList = new List<Employee>();

            foreach (Employee emp in Employees)
            {
                if (emp.FilterDelegate != null)
                {
                    if (emp.FilterDelegate(emp))
                    {
                        FilteredList.Add(emp);
                    }
                }
            }

            foreach (Employee employee in FilteredList)
                Console.WriteLine(employee);
        }
    }
}
