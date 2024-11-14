using System;

class Program
{
    static bool VerificarOrdemMesma(int[,] matriz1, int[,] matriz2)
    {
        return matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1);
    }

    static int[,] SomarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        int[,] resultado = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matriz1 = 
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matriz2 = 
        {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        if (VerificarOrdemMesma(matriz1, matriz2))
        {
            int[,] soma = SomarMatrizes(matriz1, matriz2);
            Console.WriteLine("A soma das matrizes é:");
            ExibirMatriz(soma);
        }
        else
        {
            Console.WriteLine("As matrizes não têm a mesma ordem.");
        }
    }
}
