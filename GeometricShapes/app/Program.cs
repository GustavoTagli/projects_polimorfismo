using System;
using app.Src;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            while (true)
            {
                Console.WriteLine("-- Calcular a área das formas geometricas: --");
                Console.WriteLine("[1] Quadrado");
                Console.WriteLine("[2] Retângulo");
                Console.WriteLine("[3] Triângulo");
                Console.WriteLine("[4] Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 4) break;

                switch(opcao)
                {
                    case 1:
                        Quadrado quadrado = new(4, 0, 0, 0);

                        Console.WriteLine("Valor da base:");
                        quadrado.Base = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor da altura:");
                        quadrado.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}\n");
                        break;

                    case 2:
                        Retangulo retangulo = new(4, 0, 0, 0);

                        Console.WriteLine("Valor da base:");
                        retangulo.Base = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor da altura:");
                        retangulo.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}\n");
                        break;

                    case 3:
                        Triangulo triangulo = new(3, 0, 0, 0);

                        Console.WriteLine("Valor da base:");
                        triangulo.Base = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor da altura:");
                        triangulo.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}\n");
                        break;
                }
            }
        }
    }
}
