using System;

namespace Converter
{
    class Porgram
    {
        static void Main(string[] args)
        {
            // Limpa o console
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            // Limpa console
            Console.Clear();

            bool menu = true;

            while (menu)
            {
                Console.WriteLine($"--- CONVERSOR DE TEMPERATURA ---");
                Console.WriteLine($"1 - Celsius para Fahrenheit");
                Console.WriteLine($"2 - Fahrenheit para Celsius");
                Console.WriteLine($"3 - Sair do programa");


                Console.WriteLine($"Escolha uma das opções: ");
                int choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    Celsius();
                }
                else if (choose == 2)
                {
                    Fahrenheit();
                }
                else if (choose == 3)
                {
                    Environment.Exit(0); // Sai do programa
                    Console.WriteLine($"Você está saindo do programa...");
                }
                else
                {
                    Console.WriteLine($"Digite algo válido.");
                }
                menu = false;
            }
        }

        static double Celsius()
        {
            //Limpa o console
            Console.WriteLine($"Digite uma temperatura em Celsius: ");
            double C = double.Parse(Console.ReadLine());

            double calc = C * 1.8 + 32;

            Console.WriteLine($"F: {calc.ToString("F")}°F");

            return calc;
        }

        static double Fahrenheit()
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine("Digite para converter em Fahrenheit: ");
            double F = double.Parse(Console.ReadLine());

            double calc = (F - 32) * 5 / 9;

            Console.WriteLine($"C: {calc.ToString("F")}°C");

            return calc;
        }
    }
}