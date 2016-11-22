using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o primeiro: ");
            int pn = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo: ");
            int sn = int.Parse(Console.ReadLine());

            Console.Write("Qual operação quer fazer: \tUse 1=>soma | 2=>diminuir | 3=>multiplicar | 4=>dividir\t");
            int op = int.Parse(Console.ReadLine());

            //double resultado;

            if (op == 1)
            {
                double result = somar(pn, sn);
                Console.WriteLine($"O resultado é {result}");
            }
            else if (op == 2)
            {
                double result = diminuir(pn, sn);
                Console.WriteLine($"O resultado é {result}");
            }
            else if (op == 3)
            {
                double result = multiplicar(pn, sn);
                Console.WriteLine($"O resultado é {result}");
            }
            else if (op == 4)
            {
                double result = dividir(pn, sn);
                Console.WriteLine($"O resultado é {result}");
            }

            Console.ReadKey();
        }

        public static double somar(int n1, int n2)
        {
            double result = n1 + n2;
            return result;
        }
        public static double diminuir(int n1, int n2)
        {
            double result = n1 - n2;
            return result;
        }
        public static double multiplicar(int n1, int n2)
        {
            double result = n1 * n2;
            return result;
        }
        public static double dividir(int n1, int n2)
        {
            double result = n1 / n2;
            return result;
        }
    }
}