using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region números integrais
            int numero;
            numero = 100;

            numero = 120;
            #endregion

            #region números decimais
            double num1;

            num1 = 100.32;
            #endregion

            #region Char

            char letra = 'g';


            #endregion

            #region Boolean
            bool verificar;
            verificar = false;
            #endregion

            #region String
            string nome;
            nome = Console.ReadLine();
            #endregion

            Console.WriteLine("Seu nome é: " + nome);
            Console.ReadKey();
        }
    }
}
