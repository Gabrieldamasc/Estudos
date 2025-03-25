using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            m.cumprimentar();
            m.somar(10, 15);

            Console.Write("Digite seu nome: ");
            string lerNome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string lerSobrenome = Console.ReadLine();

            string montarNome = m.montarNome(lerNome, lerSobrenome);

            Console.WriteLine("Seu nome é: " + montarNome);
           


            Console.WriteLine(montarNome);
        }
    }
}
