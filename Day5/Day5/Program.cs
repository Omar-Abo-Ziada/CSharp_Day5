using System.Collections;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IEnumerable
            //MyList myList = new MyList();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);

            //for(int i = 0; i < myList.Count; i++) 
            //{
            //    Console.WriteLine(myList.GetByIndex(i));
            //}

            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //IEnumerator enumerator = arr.GetEnumerator();

            //while(enumerator.MoveNext()) 
            //{
            //    int x = (int)enumerator.Current;
            //    Console.WriteLine(x);
            //}

            //foreach(int x in arr)
            //{

            //} 
            #endregion

            #region Object Initializer
            //Employee e1 = new Employee(10) { Name = "Test", Salary = 300 };
            //Employee e2 = new Employee { Name = "Test", Salary = 300 };
            ////e1.ID = 10;
            ////e1.Name = "Test";
            ////e1.Salary = 3000; 
            #endregion

            /*List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            //myList[8] = 10;

            int x = myList[0];// myList.GetByIndex(0);
            EmployeeList employeeList = new EmployeeList();
            Employee e = employeeList["Ahmed"];*/

            //LinkedList
            //SortedList

            /*HashSet<string> set = new HashSet<string>();
            set.Add("A");*/

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "A");
            dic.Add(2, "B");
            dic.Add(3, "C");

            //if (dic.ContainsKey(3))
            //{
            //    string s = dic[3];
            //}
          
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine($"Key = {item.Key} \t Value = {item.Value}");
            }

        }

    }
}