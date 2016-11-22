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
            int prox = 0, ant = 0, atu = 1, posicao = 0;
            Array tudo;

            Console.Write("Entre com a posição:   ");
            posicao = Int16.Parse(Console.ReadLine());

            while()
            {
                i = 1;
                prox = ant + atu;
                ant = atu;
                atu = prox;
            }

            Console.ReadKey();
        }
    }
}
