using System;

class Program
{
    static int MaiorValorMatriz(int[,] matriz)
    {
        int maiorValor = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maiorValor)
                {
                    maiorValor = matriz[i, j];
                }
            }
        }

        return maiorValor;
    }

    static void Main()
    {
        int[,] matriz = 
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("O maior valor na matriz é: " + MaiorValorMatriz(matriz));
    }
}
