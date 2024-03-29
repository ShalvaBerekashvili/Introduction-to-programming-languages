﻿/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+J. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        void FillArray2D(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = i + j;
                }
            }
        }

        void PrintArray2D(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    System.Console.Write(array2D[i, j] + " ");
                }

                System.Console.WriteLine();
            }
        }

        int m = 3;
        int n = 4;

        int[,] array2D = new int[m, n];
        FillArray2D(array2D);
        PrintArray2D(array2D);
    }
}