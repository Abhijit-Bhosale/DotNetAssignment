using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Collection_a
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Employee> objDict = new SortedList<int, Employee>();

            string flag = "YES";
            String Name;
            decimal Salary;
            int Empno;
            decimal sal=1;
            int i = 0;
            int j = 1;
            int emp;
            int n;

            while(flag=="YES")
            {
                i++;
                Console.WriteLine("Enter Employee Info");
                Console.WriteLine("Enter employee name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter employee salary");
                Salary = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter employee no");
                Empno = Convert.ToInt32(Console.ReadLine());
                
                objDict.Add(i,new Employee { name=Name,salary=Salary,empno=Empno});
                Console.WriteLine("you want to add another Employee info(YES/NO)");
                flag = Console.ReadLine();
                
            }

            foreach(KeyValuePair<int,Employee> kvp in objDict)
            {
                if(sal<kvp.Value.salary)
                {
                    sal = kvp.Value.salary;

                }
            }
            Console.WriteLine("Highest salary is={0}",sal);


            foreach(KeyValuePair<int,Employee> kvp in objDict)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine("name :{0}, Salary:{1},EmpNo:{2}",kvp.Value.name,kvp.Value.salary,kvp.Value.empno);
            }

            Console.WriteLine("Enter employee Number :");
            emp =Convert.ToInt32( Console.ReadLine());
            foreach (KeyValuePair<int, Employee> obj in objDict)
            {
                if (obj.Value.EmpNo == emp)
                {
                    Console.WriteLine("name={0},salary={1}", obj.Value.Name, obj.Value.Salary);
                }

            }

            Console.WriteLine("enter how many employee u want to show");
            n =Convert.ToInt32( Console.ReadLine());
            foreach (KeyValuePair<int, Employee> obj in objDict)
            {
                if (j<=n)
                {
                    Console.WriteLine("name={0},salary={1},empno={2}", obj.Value.Name, obj.Value.Salary,obj.Value.EmpNo);
                    j++;
                }

            }

            Console.ReadLine();
        }
    }
    class Employee
    {
        public String name;
        public decimal salary;
        public int empno;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        public int EmpNo
        {
            set
            {
                empno = value;
            }
            get
            {
                return empno;
            }
        }
    }
}
