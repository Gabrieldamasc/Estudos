using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r1 = Console.Read();

            int r2 = Console.ReadKey().KeyChar;

            Console.WriteLine("r1: " + r1);
            Console.WriteLine("r2: " + r2);
        }
    }
}
