using System;

class Program
{
    static int ContarOcorrencias(int[,] matriz, int x)
    {
        int contador = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == x)
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    static void Main()
    {
        int[,] matriz = 
        {
            { 1, 2, 3, 4 },
            { 4, 5, 6, 7 },
            { 8, 9, 4, 10 }
        };

        Console.Write("Informe o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int ocorrencias = ContarOcorrencias(matriz, x);
        Console.WriteLine($"O número {x} aparece {ocorrencias} vezes na matriz.");
    }
}
