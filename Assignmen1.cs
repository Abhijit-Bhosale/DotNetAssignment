using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Console.WriteLine(o1.EmpNo);
            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine(o2.EmpNo);
            Employee o3 = new Employee("Amol");
            Console.WriteLine(o3.EmpNo);
            Employee o4 = new Employee();
            Console.WriteLine(o4.EmpNo);
            Console.ReadLine();
        }
    }
    class Employee
    {
        //private int empno;
        private string name;
        public string Name
        {
            set
            {
                if(value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be null");
                }
            }
            get
            {
                return name;
            }
        }
        private static int empno;
        public int EmpNo
        {
            get
            {
                return empno;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 10000 && value < 20000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Basic should be between 100000 to 200000");
                }
            }
            get
            {
                return basic;
            }
        }

        private short deptno;
        public short DeptNo
        {
            set
            {
                if(value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("DeptNo should be greater than 0");
                }
            }
            get
            {
                return deptno;
            }
        }
        public Employee(string name,decimal basic, short deptno)
        {
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;
            empno=empno+1;

        }

       public Employee(string name, decimal basic)
        {
            this.name = name;
            this.basic = basic;
            deptno = 10;
            empno = empno + 1;

        }

       public Employee(string name)
        {
            this.name = name;
            basic = 110000;
            deptno = 10;
            empno = empno + 1;

        }

       public Employee()
        {
            name = "Amol";
            basic = 110000;
            deptno = 10;
            empno = empno + 1;

        }

        public decimal GetNetSalary()
        {
            return basic + 5000;
        }
    }
}
