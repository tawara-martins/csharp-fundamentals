using System;

namespace Geometry
{
    struct Circulo
    {
        public double Raio;

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }

    struct Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }

    struct Quadrado
    {
        public double Base;
        public double Altura;

        public Quadrado(double Base, double altura)
        {
            this.Base = Base;
            this.Altura = altura;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Limpa o console 
            Console.Clear();

            // Limpa o console
            Console.Clear();

            Console.WriteLine($"Você quer calcular a área de qual forma geométrica? ");
            Console.WriteLine($"1 - Área do Circulo");
            Console.WriteLine($"2 - Área do Retângulo");
            Console.WriteLine($"3 - Área do Quadrado");


            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine($"Digite o raio do circulo: ");
                double raio = double.Parse(Console.ReadLine());

                Circulo circulo = new Circulo(raio);
                Console.WriteLine($"A área do circulo: {circulo.CalcularArea()}°");
            }
            else if (opcao == 2)
            {
                Console.WriteLine($"Digite a largura do retângulo: ");
                double largura = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a altura do retângulo: ");
                double altura = double.Parse(Console.ReadLine());

                Retangulo retangulo = new Retangulo(largura, altura);
                Console.WriteLine($"A área do retângulo: {retangulo.CalcularArea()}m²");
            }
            else if (opcao == 3)
            {
                Console.WriteLine($"Digite a soma dos lados do quadrado: ");
                double Base = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a altura do quadrado: ");
                double altura = double.Parse(Console.ReadLine());

                Quadrado quadrado = new Quadrado(Base, altura);
                Console.WriteLine($"A área do quadrado: {quadrado.CalcularArea()}m² ");
            }

        }

    }
}

