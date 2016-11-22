using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoComArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("          MÉTODOS DE ORDENAÇÃO         ");
            Console.WriteLine("***************************************");

            int[] val = new int[5];

            for (int i=1;i<5;i++)
            {

                Console.Write($"Digite o {i}º valor:\t");
                val[i] = Convert.ToInt32(Console.ReadLine());
            }

            int menor = val[1];
            int maior = val[1];

            for (int i=1;i<15;i++)
            {
                int j=15;

                if (menor>val[i])
                {
                    maior = val[i];
                    val[i] = menor;
                }
            }

            for (int i=1;i<5;i++)
            {
                Console.Write($"{val[i]}, ");
            }

            Console.ReadKey();
        }
    }
}
