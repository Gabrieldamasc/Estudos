using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    static class Matematica
    {
        public static int taxa;

        public static int somar(int valor)
        {
            return valor + taxa;
        }

        public static int subtrair(int valor)
        {
            return valor - taxa;
        }
    }
}
