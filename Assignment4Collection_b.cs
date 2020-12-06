using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Collection_b
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] employees = new Employee[3];
            
            for(int i=0;i<employees.Length;i++)
            {
                Console.WriteLine("Enter name of employee");
                string name= Console.ReadLine();
                Console.WriteLine("enter salary  ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());
                employees[i] = new Employee { Name = name, Salary = salary };
            }
            List<Employee> list = employees.ToList<Employee>();
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string name;
        public decimal salary;
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
    }
}
