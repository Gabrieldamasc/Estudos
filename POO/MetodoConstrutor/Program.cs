using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa();

            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.sobreNome);
            //Console.WriteLine(p1.dataNascimento);
            //Console.WriteLine(p1.idade);

            Pessoa p2 = new Pessoa("Gabriel", "Damasceno", "10/10/2006", "18");

            Console.WriteLine("Seu nome é " + p2.nome + "Seu sobre nome é: " + p2.sobreNome + " você nasceu em: " + p2.dataNascimento + " você tem: " + p2.idade + " anos");
        }
    }
}
