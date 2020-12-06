using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager o = new GeneralManager("ASASAS", "ExManager", "Rajni", 50000, 10);
            Console.WriteLine(o.CalNetSalary());
            o.display();

            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
        void display();
    }
    public abstract class Employee : IDbFunctions
    {
        private string name;
        private int empno;
        short deptno;
        protected decimal basic;
        private static int auto;

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
                    Console.WriteLine("name should not be null");
                }
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get
            {
                return empno;
            }
        } 

        public short Deptno
        {
            set
            {
                if(value >0 && value <128)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("department no must between 0-127");
                }
            }
            get
            {
                return deptno;
            }
        }
        public abstract decimal Basic { set; get; }
        public abstract decimal CalNetSalary();

        public void display()
        {
            Console.WriteLine("IDbfunction : This is employee class");
        }

        public Employee(String name,decimal basic,short deptno)
        {
            this.Name = name;
            this.Basic = basic;
            this.Deptno = deptno;
            auto++;
            this.empno = auto;
        }

    }

    public class Manager : Employee,IDbFunctions
    {
        private string designation;

        public string Designation
        {
            set
            {
                if(value!=null)
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Designation can not be null");
                }
            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic
        {
            set
            {
                if(value>3000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Manager must have salary greater than 3000");
                }
            }
            get
            {
                return basic;
            }
        }

       // public override decimal Basic => throw new NotImplementedException();

        public override decimal CalNetSalary()
        {
            decimal netSalary;
            netSalary = basic + 3000 + 1000;
            return netSalary;
        }

        public Manager(string designation, string name, decimal basic, short deptno) : base(name, basic, deptno)
        {
            this.Designation = designation;
        }
        public new void display()
        {
            Console.WriteLine("IDbFinctions : This is Manager Class");
        }
    }
    public class GeneralManager : Manager, IDbFunctions
    {
        public override decimal Basic
        {
            set
            {
                if (value >= 50000)
                    basic = value;
                else
                    Console.WriteLine("General Manager Must have Salary grater than equal to 50000");
            }
            get
            {
                return basic;
            }
        }
        public string Perks { set; get; }
        public GeneralManager(string perks, string designation, string name, decimal basic, short deptno) : base(designation, name, basic, deptno)
        {
            this.Perks = perks;
        }
        public new void display()
        {
            Console.WriteLine("IDbFinctions : This is General Manager Class");
        }
        public override decimal CalNetSalary()
        {
            decimal netSalary;
            netSalary = basic + 5000 + 8000;
            return netSalary;

        }
    }
    public class CEO : Employee, IDbFunctions
    {
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value >= 750000)
                    basic = value;
                else
                    Console.WriteLine("CEO Must have Salary grater than equal to 750000");
            }
        }

        public override decimal CalNetSalary()
        {
            decimal netSal;
            netSal = Basic + 5000 + 10000 + 9000;
            return netSal;
        }
        public CEO(string name, decimal basic, short deptno) : base(name, basic, deptno)
        {

        }
        public new void display()
        {
            Console.WriteLine("IDbFinctions : This is CEO Class");
        }
    }
}
