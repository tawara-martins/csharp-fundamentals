using System;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine($"=== SISTEMA DE NOTAS ===");
            // Lê dados do usuário
            Console.WriteLine($"Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine($"Digite a matricula do aluno: ");
            int matriculaAluno = int.Parse(Console.ReadLine());

            // Adiciona notas do aluno
            Console.Clear();

            Console.WriteLine($"Adiciona nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Adiciona nota 2: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Adiciona nota 3: ");
            float nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Adiciona nota 4: ");
            float nota4 = float.Parse(Console.ReadLine());

            // Cálculo de médias
            float media = (nota1 + nota2 + nota3 + nota4) / 4;

            // Classificação de notas
            if (media <= 5.0 && media == 0)
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Nome do aluno: {nomeAluno}");
                Console.WriteLine($"Matricula: {matriculaAluno}");
                Console.WriteLine($"Situação: Reprovado");
            }
            else if (media >= 5.5 && media <= 5.9)
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Nome do aluno: {nomeAluno}");
                Console.WriteLine($"Matricula: {matriculaAluno}");
                Console.WriteLine($"Situação: Recuperação");
            }
            else if (media >= 6.0)
            {
                // Limpa o console
                Console.Clear();

                Console.WriteLine($"Nome do aluno: {nomeAluno}");
                Console.WriteLine($"Matricula: {matriculaAluno}");
                Console.WriteLine($"Situação: Aprovado");
            }
        }
    }
}