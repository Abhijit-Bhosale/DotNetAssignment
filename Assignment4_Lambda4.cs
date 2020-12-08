using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Lambda4
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> o4 = (a) =>
              {
                  if (a % 2 == 0)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              };
            Console.WriteLine("IsEven="+o4(12));
            Console.ReadLine();
        }
    }
}
