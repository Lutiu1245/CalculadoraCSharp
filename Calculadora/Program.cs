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
        Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é: {valorDoPrimeiroNumero / valorDoSegundoNumero}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valorDoPrimeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valorDoSegundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é: {valorDoPrimeiroNumero * valorDoSegundoNumero}");
            Console.ReadKey();
            Menu();
        }
    }
        
}