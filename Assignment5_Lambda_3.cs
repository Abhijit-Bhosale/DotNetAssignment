using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Lambda_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Employee, int> o3 = (e) =>
             {
                 return e.Da + e.Ta + e.Basic;
             };
            //Employee f = new Employee();
            Employee f = new Employee("shambhu", 2500, 1000, 150000);
            Console.WriteLine(o3(f)) ;
            Console.ReadLine();
        }      

    }

    public class Employee
    {
        private string name;
        private int da;
        private int ta;
        private int basic;

        public Employee()
        {
            name = "Abhi";
            da = 1000;
            ta = 500;
            basic = 1000;

        }
        public Employee(String name,int da,int ta,int basic)
        {
            this.name = name;
            this.ta = ta;
            this.da = da;
            this.basic = basic;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }
        public int Da
        {
            set { da = value; }
            get { return da; }
        }

        public int Ta
        {
            set { ta = value; }
            get { return ta; }
        }

        public int Basic
        {
            set { basic = value; }
            get { return basic; }
        }
    }
}
