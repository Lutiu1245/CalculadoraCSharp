using System;

namespace Calculadora
{
    class Program
    {   
        static void Main(string[] args)
        {
        //    Soma();
        //    Subtracao();
        // divisao();
        multiplicacao();
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
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {valorDoPrimeiroNumero - valorDoSegundoNumero}");
        }
        static void divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é: {valorDoPrimeiroNumero / valorDoSegundoNumero}");
        }
        static void multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é: {valorDoPrimeiroNumero * valorDoSegundoNumero}");
        }
    }
        
}