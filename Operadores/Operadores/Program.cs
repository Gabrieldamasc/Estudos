using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            string num2 = "10";
            int num3 = 2;

            int num2Int = Convert.ToInt32(num2);
            int somaNums = num1 + num2Int; // Somando os valores
            int subtracaoNums = num1 - num2Int; // Subtraindo os valores
            int multiplicacaoNums = num1 * num2Int; // Multiplicando os valores
            int divisaoNums = num1 / num2Int; // Dividindo os valores
            int restoDivisaoNums = num1 % num2Int; // Resto da divisão


            // Incremento e decremento
            int num4 = 10;
            //num4++; // Incremento out = 11
            //num4--; // Decremento out = 9
            //++num4; // Pré Incremento  out = 11
            //--num4; // Pré Decremento out = 9

            Console.WriteLine(num4++); // Imprime valor 10 e depois incrementa o valor totalizando = 11
            Console.WriteLine(num4); // Imprime valor 11

            Console.WriteLine(++num4); // Incrementa o valor totalizando = 12 e depois imprime o valor
            Console.WriteLine(--num4); // Decrementa o valor totalizando = 11 e depois imprime o valor
        }
    }
}
