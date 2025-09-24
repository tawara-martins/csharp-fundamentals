using System;

namespace TimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpa o console
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine($"--- Gerador de Tabuada ---");
                Console.WriteLine($"1 - Adição");
                Console.WriteLine($"2 - Subtração");
                Console.WriteLine($"3 - Multiplicação");
                Console.WriteLine($"4 - Divisão");
                Console.WriteLine($"5 - Sair");

                // Lê dados do usuário
                Console.WriteLine($"Qual tabuada você gostaria de gerar? ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Adicao();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    case 5:
                        Console.WriteLine($"Saindo do programa...");
                        Environment.Exit(0); // Sai do programa
                        break;
                    default:
                        Console.WriteLine($"Por favor! Digite algo válido.");
                        break;
                }

            }
        }

        static int Adicao()
        {

            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Qual número você deseja gerar uma tabuada? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} + {i} = {n + i}");
            }

            return n;
        }

        static int Subtracao()
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Qual número você deseja gerar uma tabuada? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do número {n}");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} - {i} = {n - i}");
            }

            return n;
        }

        static int Multiplicacao()
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Qual número você deseja gerar uma tabuada de multiplicação? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do número {n}");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }

            return n;
        }

        static int Divisao()
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Qual número você gostaria de gerar uma tabuada? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do número {n}");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} / {i} = {n / i}");
            }

            return n;
        }
    }
}