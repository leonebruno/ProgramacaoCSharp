using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int RESP = 0;
            int num1;
            int num2;
            char op, q;
            bool i = true;

            do
            {
                Console.WriteLine("CALCULADORA\t");
                Console.WriteLine("Digite um número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual operador usar?\n1 - SOMA | 2 - SUBTRAIR | 3 - MULTIPLICAR | 4 - DIVIDIR");
                op = char.Parse(Console.ReadLine());

                if (op == '1') { RESP = num1 + num2; }
                else if (op == '2') { RESP = num1 - num2; }
                else if (op == '3') { RESP = num1 * num2; }
                else if (op == '4') { RESP = num1 / num2; }

                Console.WriteLine("Seu resultado é " + RESP);

                Console.WriteLine("\n\nDeseja fazer novamente?\tY/N");
                q = char.Parse(Console.ReadLine());
                if (q == 'N') { i = false; }
                else { Console.Clear(); }
            } while (i == true);
            
            Console.ReadKey();
        }
    }
}
