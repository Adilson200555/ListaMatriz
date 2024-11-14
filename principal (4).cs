using System;

class Program
{
    static void ExibirDiagonalSecundaria(int[,] matriz, int n)
    {
        Console.WriteLine("Diagonal Secundária:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, n - i - 1] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int n;

        do
        {
            Console.Write("Informe o valor de N (máximo 100): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 100);

        int[,] matriz = new int[n, n];

        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = rand.Next(1, 101);
            }
        }

        ExibirDiagonalSecundaria(matriz, n);
    }
}
