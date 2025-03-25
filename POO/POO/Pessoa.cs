using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        public string nameUser;
        public int ageUser;
        public string genderUser;

        public void impressora()
        {
            Console.WriteLine("Olá eu sou o " + nameUser);
        }
    }
}
