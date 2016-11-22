using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materiaNova060916_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                Console.WriteLine("PROGRAMA RODA");
                Console.WriteLine("1 - DENOVO / 2 - SAIR");
                op = int.Parse(Console.ReadLine());
            } while (op != 2);
        }
    }
}
