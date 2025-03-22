using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    enum diaSemana
    {
        domingo,
        segunda,
        terca,
        quarta,
        quinta,
        sexta,
        sabado
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region números integrais
            //int numero;
            //numero = 100;

            //numero = 120;
            #endregion

            #region números decimais
            //double num1;

            //num1 = 100.32;
            #endregion

            #region Char

            //char letra = 'g';

            #endregion

            #region Boolean
            //bool verificar;
            //verificar = false;
            #endregion

            #region String
            //string nome;
            //nome = Console.ReadLine();
            #endregion

            #region Enum
            diaSemana dia = diaSemana.segunda;

            switch (dia)
            {
                case diaSemana.domingo:
                    Console.WriteLine("Domingo");
                    break;
                case diaSemana.segunda:
                    Console.WriteLine("Segunda");
                    break;
                case diaSemana.terca:
                    Console.WriteLine("Terça");
                    break;
                case diaSemana.quarta:
                    Console.WriteLine("Quarta");
                    break;
                case diaSemana.quinta:
                    Console.WriteLine("Quinta");
                    break;
                case diaSemana.sexta:
                    Console.WriteLine("Sexta");
                    break;
                case diaSemana.sabado:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    break;
            }
            #endregion


            Console.ReadKey();
        }
    }
}
