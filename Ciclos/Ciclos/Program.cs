using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            //while(valor < 10)
            //{
            //    Console.WriteLine("O valor atual é: " + valor++);
            //}

            //do
            //{
            //    Console.WriteLine("O Valor atual é: " + valor++);
            //} while(valor < 15);

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("O valor atual é: " + i);
            //}

            string[] nomes = {"Gabriel", "Maria", "Ana", "João", "Marcos"};

            foreach(var nome in nomes)
            {
                Console.WriteLine("O nome atual é: " + nome);
            }
        }
    }
}
