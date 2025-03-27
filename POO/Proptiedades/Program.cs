using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proptiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste p1 = new Teste();

            p1.Idade = int.Parse(Console.ReadLine());
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + p1.Nome + " e você tem " + p1.Idade + " anos");

        }
    }
}
