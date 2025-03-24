using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Método de escolha do usuário

        Inicio:

            Console.WriteLine("======== Calculadora ========");
            Console.WriteLine("Escolha uma das opções de cálculo: ");
            Console.WriteLine("1 -> Para Soma");
            Console.WriteLine("2 -> Para Subtração");
            Console.WriteLine("3 -> Para Divisão");
            Console.WriteLine("4 -> Para Multiplicação");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    Console.WriteLine("Digite os números para soma");
                    Console.Write("Digite o primeiro número: ");
                    double inSoma1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double inSoma2 = double.Parse(Console.ReadLine());
                    double soma = inSoma1 + inSoma2;
                    Console.WriteLine("O resultado da soma foi: " + soma);
                    Console.Write("Deseja sair da aplicação? (S/N): ");
                    string userChoose = Console.ReadLine();
                    if(userChoose.IndexOf("s", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        break;
                    }
                    else
                    {
                        goto Inicio;
                    }
                case 2:
                    Console.WriteLine("Digite os números para subtração");
                    Console.Write("Digite o primeiro número: ");
                    double inSubtracao1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double inSubtracao2 = double.Parse(Console.ReadLine());
                    double resultSubtracao = inSubtracao1 - inSubtracao2;
                    Console.WriteLine("O resultado da subtração foi: " + resultSubtracao);
                    Console.Write("Deseja sair da aplicação? (S/N): ");
                    string userChoose1 = Console.ReadLine();
                    if(userChoose1.IndexOf("s", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        break;
                    }
                    else
                    {
                        goto Inicio;
                    }
                case 3:
                    Console.WriteLine("Digite os números para Divisão");
                    Console.Write("Digite o primeiro número: ");
                    double inDivisao1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double inDivisao2 = double.Parse(Console.ReadLine());
                    double resultDivisao = inDivisao1 - inDivisao2;
                    Console.WriteLine("O resultado da divisão foi: " + resultDivisao);
                    Console.Write("Deseja sair da aplicação? (S/N): ");
                    string userChoose2 = Console.ReadLine();
                    if(userChoose2.IndexOf("s", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        break;
                    }
                    else
                    {
                        goto Inicio;
                    }
                case 4:
                    Console.WriteLine("Digite os números para Multiplicação");
                    Console.Write("Digite o primeiro número: ");
                    double inMultiplicação1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double inMultiplicação2 = double.Parse(Console.ReadLine());
                    double resultMultiplicação = inMultiplicação1 - inMultiplicação2;
                    Console.WriteLine("O resultado da multiplicação foi: " + resultMultiplicação);
                    Console.Write("Deseja sair da aplicação? (S/N): ");
                    string userChoose3 = Console.ReadLine();
                    if(userChoose3.IndexOf("s", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        break;
                    }
                    else
                    {
                        goto Inicio;
                    }
            }

        }
    }
}
