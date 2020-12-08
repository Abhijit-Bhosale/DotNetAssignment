using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Lambda_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int,bool> o2 = (a, b) =>
               {
                   if (a > b)
                       return true;
                   else
                       return false;
               };
            Console.WriteLine( o2(10, 20));
            Console.ReadLine();
        }
    }
}
