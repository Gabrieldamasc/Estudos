using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
     
        //Métodos simples
        public void cumprimentar()
        {
            Console.WriteLine("Olá seja bem vindo");
        }

        //Métodos com parâmetros
         public void somar(int n1, int n2)
        {
            int soma = n1 + n2;
            Console.WriteLine("A soma foi: " + soma);
        }

        //Métodos com retorno

        public string montarNome(string nome, string sobreNome)
        {
            return nome + " " + sobreNome;
        }
    }
}
