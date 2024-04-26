namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company() { Budget = 100_000 };
            Employee e1 = new Employee() { NID = "1", Name = "Ahmed", Salary = 5000, Gender = Gender.male };
            Employee e2 = new Employee() { NID = "2", Name = "Sara", Salary = 4000, Gender = Gender.female };
            Employee e3 = new Employee() { NID = "3", Name = "Emad", Salary = 8000, Gender = Gender.male };
            Employee e4 = new Employee() { NID = "4", Name = "Ali", Salary = 12_000 , Gender = Gender.male };

            company.Add(e1);
            company.Add(e2);
            company.Add(e3);
            company.Add(e4);

            foreach(Employee emp in company.Employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("----------------------------------------------");

            //Console.WriteLine(company.IsMale(e2));

            //Console.WriteLine(company.IsVIP(e4));

            e1.IncreaseSalary(1000m);
            e1.IncreaseSalary(1000m);

            e2.IncreaseSalary(1000m);
            e3.IncreaseSalary(1000m);

            Console.WriteLine($"{e2.Name} salary after increase : {e1.Salary}");

            // or the user can choose his own filter method as long it matches the Predicate-delegate signature 
            foreach (Employee e in company.Employees)
            {
               // e.FilterDelegate += IsFemle;
            }

            company.Filter();
        }
        // the user filter method 
        public static bool IsFemle(Employee emp)
        {
            return emp.Gender == Gender.female;
        }
    }
}
