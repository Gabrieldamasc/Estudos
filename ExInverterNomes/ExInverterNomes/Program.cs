using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.Write("Digite o primeiro nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o segundo nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o terceiro nome: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o quarto nome: ");
            nome4 = Console.ReadLine();

            // Método para inverter o nome

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

            Console.WriteLine("Nomes invertidos na ordem inserida: ");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

        }
    }
}
