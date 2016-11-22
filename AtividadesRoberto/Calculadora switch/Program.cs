using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, res = 0;
            String op;

            Console.Write("Primeiro número:\t");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Qual operador:\nUse 1 = soma 2 = subtração 3 = multiplição 4 divisao");
            op = Console.ReadLine();

            Console.Write("Segundo programa:\t");
            num2 = float.Parse(Console.ReadLine());

            switch(op)
            {
                case("1"):
                    res = num1 + num2;
                    break;

                case ("2"):
                    res = num1 - num2;
                    break;

                case ("3"):
                    res = num1 * num2;
                    break;

                case ("4"):
                    res = num1 / num2;
                    break;

                default:
                    Console.WriteLine($"Operador invalido {op}");
                    break;
            }
            Console.WriteLine($"O resultado é {res}");
            Console.ReadKey();
        }
    }
}
