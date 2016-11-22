using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoisDoChinesinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 0, A = 10, B = 2;

            Console.WriteLine("A\tB\tR");
            while (B > 0)
            {
                Console.WriteLine("{0}\t{1}\t{2}", A, B, R);
                R = R + A;
                B = B - 1;
            }
            Console.WriteLine(R);
            Console.ReadLine();
        }
    }
}