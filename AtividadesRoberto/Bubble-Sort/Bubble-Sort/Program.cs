using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1009, 54, 87, 86, 01, 54, 74 };

            Console.WriteLine("Atividade Bubble Short");

            bubbleSort(numeros, numeros.Length);

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
            Console.ReadLine();
        }
        static void bubbleSort(int[] arr, int lenght)
        {
            int percorre = 0;
            /*Irá percorrer o vetor, comparando cada elemento do vetor com o elemento 
             * imediatamente seguinte (arr[j] = arr[j + 1];) 
             * O numero maximo de execuções do trecho do algoritmo 
             * p/ que o vetor fique ordenado é de N - 1, onde N é o numero de vezes.*/

            /* Will go through the vector, comparing each element of the array with the element 
             * immediately following (arr[j] = arr[j + 1];) 
             * The maximum number of implementation of the algorithm for the vector section be  
             * ordained is N - 1, where N is the number of times.  
             */

            // i determina o número de etapas para a ordenação 
            // i determines the number of steps for sorting

            for(int i = 0; i < lenght -1; i++)
            {
                // j determina o numero de comparações em cada etapa e os indices a serem 
                //pesquisados para a comparação. 
                // j determines the number of comparisons in each step and the indices to be 
                // studied for comparison 
                for(int j = 0; j < lenght - (i + 1); j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        percorre = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = percorre;
                    }
                }
            }
        }
    }
}
