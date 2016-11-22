using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int prox = 0, ant = 0, atu = 1, q = 0;

            Console.Write("Entre com o número:   ");
            q = Int16.Parse(Console.ReadLine());

            for(int i = 0; i < q; i++)
            {
                Console.Write($"{ant}\n");

                prox = ant + atu;
                ant = atu;
                atu = prox;
            }

            Console.ReadKey();
        }
    }
}
