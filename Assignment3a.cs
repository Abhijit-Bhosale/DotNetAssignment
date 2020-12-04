using ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.a
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sal=1;
            int s;
            int emp;
            Console.WriteLine("Enter no of employee");
            s = Convert.ToInt32(Console.ReadLine());
            Employee[] employees = new Employee[s];
            
            for(int j=0;j<employees.Length;j++)
            {
                employees[j] = new Employee();
                Console.WriteLine("enter {0} employee name ",j);
                employees[j].Name= Console.ReadLine();
                Console.WriteLine("enter {0} employee salary",j);
                employees[j].Salary =Convert.ToDecimal( Console.ReadLine());
                Console.WriteLine("enter {0} employee age",j);
                employees[j].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter {0} employee empno",j);
                employees[j].EmpNo = Convert.ToInt32(Console.ReadLine());
            }

            foreach (Employee item in employees)
            {
                if(sal < item.Salary)
                {
                    sal = item.Salary;
                }

            }
            Console.WriteLine("Highest salary is ={0}", sal);

            Console.WriteLine("Enter EmpNo ");
            emp = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<employees.Length;i++)
            {
                if(emp==employees[i].EmpNo)
                {
                    Console.WriteLine("Employee Name {0}",employees[i].Name);
                    Console.WriteLine("Employee salary {0}", employees[i].Salary);
                    Console.WriteLine("Employee Age {0}", employees[i].Age);
                    //Console.WriteLine("Employee empno {0}", employees[i].EmpNo);
                }
         
            }


            Console.ReadLine();


        }
    }
    public class Employee
    {
        private string name;
        private decimal salary;
        private int age;
        private int empno;

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
         public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
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
