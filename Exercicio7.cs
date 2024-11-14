using System;

class Program
{
    static double[,] SomarMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static double[,] SubtrairMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz2[i, j] - matriz1[i, j];
            }
        }

        return resultado;
    }

    static void AdicionarConstante(double[,] matriz, double constante)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] += constante;
            }
        }
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n, m;

        Console.Write("Informe o número de linhas (N): ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de colunas (M): ");
        m = int.Parse(Console.ReadLine());

        double[,] matriz1 = new double[n, m];
        double[,] matriz2 = new double[n, m];

        Console.WriteLine("Digite os elementos da primeira matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Matriz 1 [{i}, {j}]: ");
                matriz1[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os elementos da segunda matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Matriz 2 [{i}, {j}]: ");
                matriz2[i, j] = double.Parse(Console.ReadLine());
            }
        }

        int opcao;
        do
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("1. Somar as duas matrizes");
            Console.WriteLine("2. Subtrair a primeira matriz da segunda");
            Console.WriteLine("3. Adicionar uma constante às duas matrizes");
            Console.WriteLine("4. Imprimir as matrizes");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double[,] soma = SomarMatrizes(matriz1, matriz2);
                    Console.WriteLine("\nResultado da soma das matrizes:");
                    ImprimirMatriz(soma);
                    break;

                case 2:
                    double[,] subtracao = SubtrairMatrizes(matriz1, matriz2);
                    Console.WriteLine("\nResultado da subtração das matrizes:");
                    ImprimirMatriz(subtracao);
                    break;

                case 3:
                    Console.Write("Informe a constante a ser adicionada: ");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionarConstante(matriz1, constante);
                    AdicionarConstante(matriz2, constante);
                    Console.WriteLine("\nConstante adicionada às matrizes.");
                    break;

                case 4:
                    Console.WriteLine("\nPrimeira matriz:");
                    ImprimirMatriz(matriz1);
                    Console.WriteLine("\nSegunda matriz:");
                    ImprimirMatriz(matriz2);
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 5);
    }
}
