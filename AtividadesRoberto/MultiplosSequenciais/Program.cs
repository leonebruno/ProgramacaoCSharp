using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosSequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 0, A = 0, B = 0;

            Console.Write("Digite R");
            R = Int16.Parse(Console.ReadLine());

            Console.Write("Entre com A");
            A = Int16.Parse(Console.ReadLine());

            Console.Write("Entre com B");
            A = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < B; i++)
            {
                R = (R + A);
            }

        }
    }
}
