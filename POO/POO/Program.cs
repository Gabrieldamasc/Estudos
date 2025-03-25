using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos
            //Console.WriteLine("Classe 1");
            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = new OutraClasse();
            #endregion

            
            Pessoa p1 = new Pessoa();

            p1.nameUser = "gabriel";
            p1.ageUser = 18;
            p1.genderUser = "masculino";

            Console.WriteLine("seu nome é: " + p1.nameUser);
            Console.WriteLine("sua idade é: " + p1.ageUser);
            Console.WriteLine("seu gênero é: " + p1.genderUser);

            p1.impressora();
        }
    }
}
