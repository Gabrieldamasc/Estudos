using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Calculadora de IMC ==============");

            Console.Write("digite seu peso: ");
            double userWeight = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double userHeight = double.Parse(Console.ReadLine());

            //Calcular o IMC

            double calculoIMC = userWeight / (userHeight * userHeight);
            
            if(calculoIMC < 18.5)
            {
                Console.WriteLine("Seu IMC foi de: "+ calculoIMC + "Você está abaixo do peso");
            }
            else if(calculoIMC > 18.5 && calculoIMC < 24.99)
            {
                Console.WriteLine("Seu IMC foi de: "+ calculoIMC + " Você está no peso ideal");
            }
            else if(calculoIMC > 25 && calculoIMC < 29.99)
            {
                Console.WriteLine(" Seu IMC foi de: "+ calculoIMC + " Você está com sobrepeso");
            }
            else
            {
                Console.WriteLine(" Seu IMC foi de: "+ calculoIMC + " Você está com obesidade");
            }

            Console.WriteLine("============== Fim do programa ==============");
        }
    }
}
