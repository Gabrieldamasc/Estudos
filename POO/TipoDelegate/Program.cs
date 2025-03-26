using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void operacao(int n1, int n2);
        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            operacao conta = null;

            conta += m.somar;
            conta += m.subtrair;
            conta += m.multiplicacao;
            conta += m.divisao;

            conta(10, 5);
        }
    }
}
