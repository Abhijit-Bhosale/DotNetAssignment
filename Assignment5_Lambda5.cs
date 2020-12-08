using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5_Lambda5
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> o5=(a)=>
                {
                    if (a > 10000)
                        return true;
                    else
                        return false;

            };
            Console.WriteLine("salary is greater than 10000"+o5(12000));
            Console.ReadLine();
        }
    }
}
