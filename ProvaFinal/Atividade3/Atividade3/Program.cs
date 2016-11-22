using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[30];
            int menor = 0;
            int atual = 0;
            int maior = 0;

            for (int i = 0; i<=5; i++)
            {
                Console.WriteLine("Entre com o valor: ");
                valor[i] = int.Parse(Console.ReadLine());

                atual = valor[i];

                if (valor[0] != 0)
                {
                    menor = atual;
                }
                if (atual < menor)
                {
                    menor = atual;
                }
                else if (atual > maior)
                {
                    maior = atual;
                }
            }

            Console.WriteLine("Menor é " + menor + " e maior é " + maior);

            Console.ReadKey();
        }
    }
}
