using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Sequência de fibonacci =========");
            Console.Write("Quantos números você deseja na sequência: ");
            int userInput = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            for(int i = 0; i < userInput; i++) 
            {
                if(i < userInput - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a + ".");
                }
               
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
