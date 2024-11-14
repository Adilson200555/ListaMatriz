using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Digite o tamanho da matriz N (N x N): ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = rand.Next(1, 101);
            }
        }

        Console.WriteLine("\nMapa do Tesouro (Quantidade de Moedas em Cada Região):");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int somaDiagonalPrincipal = 0;
        for (int i = 0; i < N; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
        }

        int somaDiagonalSecundaria = 0;
        for (int i = 0; i < N; i++)
        {
            somaDiagonalSecundaria += matriz[i, N - i - 1];
        }

        Console.WriteLine("\nSoma da Diagonal Principal: " + somaDiagonalPrincipal);
        Console.WriteLine("Soma da Diagonal Secundária: " + somaDiagonalSecundaria);

        if (somaDiagonalPrincipal > somaDiagonalSecundaria)
        {
            Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
        }
        else if (somaDiagonalPrincipal < somaDiagonalSecundaria)
        {
            Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
        }
        else
        {
            Console.WriteLine("Ambas as diagonais têm o mesmo valor de tesouro, escolha qualquer uma!");
        }
    }
}
