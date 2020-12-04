using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch;
            int stud;
            Console.WriteLine("Enter number of batches in CDAC");
            batch = Convert.ToInt32(Console.ReadLine());
            int[][]  arr = new int[batch][ ];

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("enter student in batch {0}",i);
                 stud = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[stud];
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.WriteLine("batch no {0} student no {1} enter marks", i,j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("batch no {0} student no {1}  marks ={2}", i, j,arr[i][j]);
                }
            }
            Console.ReadLine();
        }
       
    }
}
