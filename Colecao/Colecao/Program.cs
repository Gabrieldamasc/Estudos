using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat01 = new int [2,3];
            int[,] mat02 = new int[3,2];
            int[,] matResultado = new int[2,2];

            // Ler a primeira matriz
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("1° posição [" + i + " ] [ "  + j + " ]: ");
                    mat01[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ler a segunda Matriz: ");

            // Ler a segunda matriz
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("2° posição [" + i + "] [ " + j + " ]: ");
                    mat02[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Resultado da matriz 1 x 2: ");
            matResultado[0, 0] = (mat01[0, 0] * mat02[0, 0]) + (mat01[0, 1] * mat02[1, 0]) + (mat01[0, 2] * mat02[2, 0]);
            matResultado[1, 0] = (mat01[1, 0] * mat02[0, 0]) + (mat01[1, 1] * mat02[1, 0]) + (mat01[1, 2] * mat02[2, 0]);
            matResultado[0, 1] = (mat01[0, 0] * mat02[0, 1]) + (mat01[0, 1] * mat02[1, 1]) + (mat01[0, 2] * mat02[2, 1]);
            matResultado[1, 1] = (mat01[1, 0] * mat02[0, 1]) + (mat01[1, 1] * mat02[1, 1]) + (mat01[1, 2] * mat02[2, 1]);

            Console.WriteLine("["+ matResultado[0, 0] + "] [" + matResultado[0, 1] + "]");
            Console.WriteLine("["+ matResultado[1, 0] + "] [" + matResultado[1, 1] + "]");
        }
    }
}
