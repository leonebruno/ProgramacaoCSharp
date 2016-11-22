using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenacaoSemNome
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int[] vet = new int[10];
            bool troca;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com o valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                troca = false;
                for(int i = 0;i < (10 - 1); i++)
                {
                    if (vet[i] < vet[i+1])
                    {
                        aux = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = aux;
                        troca = true;
                    }
                }
                    
            } while (troca);
            for(int i = 0; i < 10; i++)
            {
                Console.Write(vet[i] + ", ");
            }
        }
    }
}