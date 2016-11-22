using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplosDeCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, mult = 1, i = 0;
            do { 
                i++;
                num = i;
                Console.WriteLine(mult);
                mult = 5 * num;
            } while (i<=10);

            Console.ReadKey();
        }
    }
}
