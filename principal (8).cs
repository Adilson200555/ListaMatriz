using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Digite o número de regiões (R): ");
        int R = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de cidades (C) em cada região: ");
        int C = int.Parse(Console.ReadLine());

        int[,] matriz = new int[R, C];

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                matriz[i, j] = rand.Next(0, 101);
            }
        }

        Console.WriteLine("\nMatriz das Tropas (Quantidade de Tropas por Cidade):");
        for (int i = 0; i < R; i++)
        {
            Console.Write($"Região {i + 1}: ");
            for (int j = 0; j < C; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nForça Total das Regiões:");
        for (int i = 0; i < R; i++)
        {
            int somaTropas = 0;
            for (int j = 0; j < C; j++)
            {
                somaTropas += matriz[i, j];
            }
            Console.WriteLine($"Região {i + 1}: {somaTropas} tropas");
        }
    }
}
