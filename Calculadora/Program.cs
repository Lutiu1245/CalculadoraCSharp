using System;

namespace Calculadora
{
    class Program
    {   
        static void Main(string[] args)
        {
           Soma();
        }
        static void Soma()
        {
             Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {valorDoPrimeiroNumero + valorDoSegundoNumero}");
        }
    }
}