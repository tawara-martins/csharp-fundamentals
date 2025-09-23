using System;

namespace Calculator
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
                Console.WriteLine($"=== MENU ===");

                // Menu 
                Console.WriteLine($"1 - Adição");
                Console.WriteLine($"2 - Subtração");
                Console.WriteLine($"3 - Multiplicação");
                Console.WriteLine($"4 - Divisão");
                Console.WriteLine($"5 - Sair do programa");

                // Choose the options
                Console.WriteLine($"Qual operação você deseja realizar? ");
                int options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Environment.Exit(0); // Sai do programa
                        Console.WriteLine($"Você está saindo do programa...");
                        break;
                    default:
                        Console.WriteLine($"Digite uma opção válida.");
                        break;
                }
                menu = false;
            }

            static int Addition()
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Você escolheu adição! Digite o primeiro número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o segundo número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 + n2;

                Console.WriteLine($"O resultado de {n1} + {n2}: {result}");
                return result;
            }

            static int Subtraction()
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Você escolheu subtração! Digite o primeiro número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Agora, digite o segundo número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 - n2;

                Console.WriteLine($"O resultado de {n1} - {n2}: {result}");

                return result;
            }

            static int Multiplication()
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Eba, você escolheu multiplicação! Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o segundo número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 * n2;

                Console.WriteLine($"O resultado de {n1} x {n2}: {result}");

                return result;
            }

            static int Division()
            {
                Console.Clear();

                Console.WriteLine($"Você escolheu divisão. Digite um número inteiro:    ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite aqui um número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine($"O resultado de {n1} / {n2} : {result}");

                return result;
            }
        }
    }
}
