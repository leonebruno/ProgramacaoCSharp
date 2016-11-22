using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProg
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome1;
            String nome2;
            String confirmacao;
            //int numero1;
            //int numero2;
            //int resultado;
            //String operacao;
            Console.WriteLine("What's your firt name? ");
            nome1 = Console.ReadLine();
            Console.WriteLine("And your lest name? ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Your realy name is " + nome1 + " " + nome2 + "?\nPress y/n");
            confirmacao = Console.ReadLine();
            if (confirmacao == "y")
            {
                Console.WriteLine("Oh Good!");
                Console.WriteLine("Good!\nNow let's go to very must interessing...");
            }
            else
            {
                Console.WriteLine("I'm sorry! Let's go novamente");
            }
            Console.ReadKey();
        }
    }
}
