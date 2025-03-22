using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine(" ======================== CONVERSOR DE TEMPERATURAS ========================");
            Console.WriteLine("Qual o tipo de temperatura você deseja converter?");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Celsius para Kelvin");
            Console.WriteLine("3 - Fahrenheit para Celsius");
            Console.WriteLine("4 - Fahrenheit para Kelvin");
            Console.WriteLine("5 - Kelvin para Celsius");
            Console.WriteLine("6 - Kelvin para Fahrenheit");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------");

            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    double tempCelsius = Convert.ToDouble(Console.ReadLine());
                    double resultadoC = tempCelsius * 1.8 + 32;
                    Console.WriteLine("A temperatura em Fahrenheit é: " + resultadoC);
                    break;
                case 2:
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    double tempCelsius2 = Convert.ToDouble(Console.ReadLine());
                    double resultadoK = tempCelsius2 + 273.15;
                    Console.WriteLine("A temperatura em Kelvin é: " + resultadoK);
                    break;
                case 3:
                    Console.WriteLine("Digite a temperatura em Fahrenheint: ");
                    double tempFahrenheint = Convert.ToDouble(Console.ReadLine());
                    double resultadoC2 = (tempFahrenheint - 32) / 1.8;
                    Console.WriteLine("A temperatura em Celsius é: " + resultadoC2);
                    break;
                case 4:
                    Console.WriteLine("Digite a temperatura em Fahrenheint: ");
                    double tempFahrenheint2 = Convert.ToDouble(Console.ReadLine());
                    double resultadoK2 = (tempFahrenheint2 - 32) / 1.8 + 273.15;
                    Console.WriteLine("A temperatura em Kelvin é: " + resultadoK2);
                    break;
                case 5: 
                    Console.WriteLine("Digite a temperatura em Kelvin: ");
                    double tempKelvin = Convert.ToDouble(Console.ReadLine());
                    double resultadoC3 = tempKelvin - 273.15;
                    Console.WriteLine("A temperatura em Celsius é: " + resultadoC3);
                    break;
                case 6:
                    Console.WriteLine("Digite a temperatura em Kelvin: ");
                    double tempKelvin2 = Convert.ToDouble(Console.ReadLine());
                    double resultadoF = (tempKelvin2 - 273.15) * 1.8 + 32;
                    Console.WriteLine("A temperatura em Fahrenheit é: " + resultadoF);
                    break;
            }
        }
    }
}
