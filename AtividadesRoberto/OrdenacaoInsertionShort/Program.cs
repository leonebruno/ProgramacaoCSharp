using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoInsertionShort
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] insertionShort(int[] vetor)
        {
            int i, j, atual;

            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];

                j = i;

                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];

                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }
    }
}
