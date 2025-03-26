using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public string dataNascimento;
        public string idade;

        public Pessoa()
        {
            nome = "desconhecido";
            sobreNome = "desconhecido";
            dataNascimento = "0";
            idade = "0";
        }

        public Pessoa(string nome, string sobreNome, string dataNascimento, string idade)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.dataNascimento = dataNascimento;
            this.idade = idade;
        }
    }
}
