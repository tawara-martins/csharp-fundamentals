using System;

namespace Tasks
{
    struct Tarefa
    {
        public string Titulo;
        public string Descricao;
        public Tarefa(string titulo, string descricao)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
        }

        public void ExibirInformacoes()
        {
            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Descrição: {Descricao}");
        }

    };
    class Program
    {
        public static void Main(string[] args)
        {
            // Limpa o console
            Console.Clear();

            // Menu

            Console.WriteLine($"=== SISTEMA DE REGISTRO DE TAREFAS ===");

            Console.WriteLine($"1 - Adicionar uma nova tarefa");
            Console.WriteLine($"2 - Visualizar tarefa");
            Console.WriteLine($"3 - Marcar como concluída");

            Console.WriteLine($"Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());


            if (escolha == 1)
            {
                Console.WriteLine($"Digite o título da nova tarefa: ");
                string titulo = Console.ReadLine();

                Console.WriteLine($"Digite a descrição da tarefa: ");
                string descricao = Console.ReadLine();

                Tarefa tarefa = new Tarefa(titulo, descricao);
                Console.WriteLine($"Tarefa adicionada com sucesso.");
            }
            else if (escolha == 2)
            {
                Console.WriteLine($"Digite o título que deseja visualizar: ");
                string titulo = Console.ReadLine();

                Tarefa tarefa = new Tarefa(titulo, "descrição de exemplo");
                tarefa.ExibirInformacoes();
            }
        }
    }
}
