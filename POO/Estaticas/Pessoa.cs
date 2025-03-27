using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Pessoa
    {
        public static int maioridade = 18;
        public int idade;
        public string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public static int calcularIdade(int dataNascimento)
        {
            return DateTime.Now.Year - dataNascimento;
        }

        public void apresentação()
        {
            Console.WriteLine("Olá eu sou o " + nome);
        }

    }
}
