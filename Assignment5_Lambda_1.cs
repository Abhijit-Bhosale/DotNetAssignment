using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> o1 = (a, b, c) => (a * b * c) / 100;
           Console.WriteLine("SI "+ o1((decimal)10000, (decimal)3.5, (decimal)2.5));
            Console.ReadLine();
        }
    }
}
