using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Métodos estáticos
            //Matematica.taxa = 100;

            //int valorSoma = Matematica.somar(200);
            //int valorSubtração = Matematica.subtrair(200);

            //Console.WriteLine("A soma é: " + valorSoma);
            //Console.WriteLine("A subtração é: " + valorSubtração);
            #endregion

            #region Membros estáticos
            Pessoa p1 = new Pessoa("Gabriel");

            p1.idade = Pessoa.calcularIdade(2006);

            p1.apresentação();
            Console.WriteLine("Você tem " + p1.idade + " anos");

            #endregion

        }

    }
}
