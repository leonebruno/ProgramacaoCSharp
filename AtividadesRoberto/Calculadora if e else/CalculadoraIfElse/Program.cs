using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, res = 0;
            String op;

            Console.Write("Digite o primeiro número: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o operador: + - * /");
            op = Console.ReadLine();

            Console.Write("Digite o segundo operador: ");
            num2 = Double.Parse(Console.ReadLine());

            if (op == "+") { res = num1 + num2; }
            else if (op == "-") { res = num1 - num2; }
            else if (op == "*") { res = num1 * num2; }
            else if (op == "/") { res = num1 / num2; }

            Console.WriteLine("Seu resultado é " + res);

            Console.ReadKey();
        }
    }
}
