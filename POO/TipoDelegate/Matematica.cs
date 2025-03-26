using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void somar(int num1, int num2)
        {
            Console.WriteLine("A soma é: " + (num1 + num2));
        }

        public void subtrair(int num1, int num2)
        {
            Console.WriteLine("A subtração é: " + (num1 - num2));
        }
        public void multiplicacao(int num1, int num2)
        {
            Console.WriteLine("A multiplicação é: " + (num1 * num2));
        }
        public void divisao(int num1, int num2)
        {
            Console.WriteLine("O resultado da divisão é: " + (num1 / num2));
        }
    }
}
