using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("enter no of students");
            s = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[s];
            for(int i=0;i<students.Length;i++)
            {
                students[i] = new Student();
                Console.WriteLine("Enter {0} student name",i);
                students[i].Name = Console.ReadLine();
                Console.WriteLine("Enter {0} student rollno", i);
                students[i].RollNo =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter {0} student marks", i);
                students[i].Marks = Convert.ToDecimal(Console.ReadLine());
            }
            for(int j=0;j<students.Length;j++)
            {
                Console.WriteLine("{0}Student name={1}",j,students[j].Name);
                Console.WriteLine("{0}Student rollno={1}", j, students[j].RollNo);
                Console.WriteLine("{0}Student name={1}", j, students[j].Marks);
            }
            Console.ReadLine();
        }
    }
    public struct Student
    {
        private string name;
        private int rollno;
        private decimal marks;

        Student(String name,int rollno,decimal marks)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks = marks;
        }
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

        public int RollNo
        {
            set
            {
                if(value>0)
                {
                    rollno = value;
                }
            }
            get
            {
                return rollno;
            }
        }
         public decimal Marks
        {
            set
            {
                if(value>=0 && value <=100)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("marks shoub be between 0-100");
                }
            }
            get
            {
                return marks;
            }
        }
    }
}
