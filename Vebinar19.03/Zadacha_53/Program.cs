/*
Задача 53:Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива
*/
internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray2D(int[,] array2D)
        {
            Random random = new Random();
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = random.Next(1, 10);
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

        void SwapRowsInArray2D(int[,] array2D)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                int lastRowIndex = array2D.GetLength(0) - 1;
                int firstRowIndex = 0;

                (array2D[firstRowIndex, j], array2D[lastRowIndex, j]) = (array2D[lastRowIndex, j], array2D[firstRowIndex, j]);
            }
        }

        int rows = 3;
        int сolumns = 4;

        int[,] array2D = new int[rows, сolumns];

        FillArray2D(array2D);
        PrintArray2D(array2D);
        SwapRowsInArray2D(array2D);
        System.Console.WriteLine();
        PrintArray2D(array2D);
    }
}