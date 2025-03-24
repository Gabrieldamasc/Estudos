using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite algum número entre 1 e 3: ");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Escolha 1");
                    break;
                case 2:
                    Console.WriteLine("Escolha 2");
                    break;
                case 3:
                    Console.WriteLine("Escolha 3");
                    break;
                default:
                    Console.WriteLine("Nenhuma escolha válida");
                    break;
            }
        }
    }
}
