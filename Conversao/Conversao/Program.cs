using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Conversão de tipos

            int a = 10;
            double b = a; // Conversão implícita
            Console.WriteLine(b);
            double c = 10.5;

            int d = (int)c; // Conversão explícita
            Console.WriteLine(d);

            // Conversão de tipos com Parse
            string e = "10";
            int f = int.Parse(e);
            Console.WriteLine(f);

            // Conversão de tipos com TryParse
            string g = "10";
            int h;
            if(int.TryParse(g, out h))
            {
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("Conversão inválida");
            }

            // Conversão de tipos com Convert
            string i = "10";
            int j = Convert.ToInt32(i);
            Console.WriteLine(j);

            // Conversão de tipos com ToString
            int k = 10;
            string l = k.ToString();
            Console.WriteLine(l);

            // Conversão de tipos com Format
            int m = 10;
            string n = string.Format("{0}", m);
            Console.WriteLine(n);

            // Conversão de tipos com Interpolação
            int o = 10;
            string p = $"{o}";
            Console.WriteLine(p);

            // Conversão de tipos com ToString
            int q = 10;
            string r = q.ToString();
            Console.WriteLine(r);

            // Conversão de tipos com Format
            int s = 10;
            string t = string.Format("{0}", s);
            Console.WriteLine(t);

            // Conversão de tipos com Interpolação
            int u = 10;
            string v = $"{u}";
            Console.WriteLine(v);

            // Conversão de tipos com ToString
            int w = 10;
            string x = w.ToString();
            Console.WriteLine(x);

            // Conversão de tipos com Format
            int y = 10;
            string z = string.Format("{0}", y);
            Console.WriteLine(z);

            // Conversão de tipos com Interpolação
            int aa = 10;
            string ab = $"{aa}";
            Console.WriteLine(ab);

            // Conversão de tipos com ToString
            int ac = 10;
            string ad = ac.ToString();
            Console.WriteLine(ad);

            // Conversão de tipos com Format
            int ae = 10;
            string af =
        }
    }
}
