using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, a, b, c, d;

            Console.Write("Entre com o primeiro numero:\t");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o primeiro numero:\t");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o primeiro numero:\t");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o primeiro numero:\t");
            n4 = int.Parse(Console.ReadLine());

            a = n1;
            b = n2;
            c = n3;
            d = n4;

            do
            {
                if (a < b)
                {
                    a = b;
                    b = a;
                    if (b < c)
                    {
                        b = c;
                        c = b;
                        if (c < d)
                        {
                            c = d;
                            d = c;
                        }
                    }
                }
            } while (a > b || a > c || a > c || a > d || b > c || b > d || c > d);

            Console.WriteLine($"{a}, {b}, {c}, {d}");

            Console.ReadKey();
        }
    }
}
