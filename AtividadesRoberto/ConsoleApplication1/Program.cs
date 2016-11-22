using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int atual = 0, i = 1;
            Console.WriteLine("Digite um numero menor que 0");
            atual=Convert.ToInt16(Console.ReadLine());
            while (atual > 0)
            {
                Console.WriteLine("Digite novamente um numero menor que 0");
                atual = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine($"Numero digitado {atual}");
            
            Console.ReadKey();
        }
    }
}
