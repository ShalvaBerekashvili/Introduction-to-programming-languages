/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

void FillArray2D(int [,] array2D)
{
    Random rand = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rand.Next(1, 10);
        }
    }
}

int SummDioganalArrya(int[,] array2D)
{
    int result = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array2D[i, j];;                
            }
        }
    }
    return result;
}


void PrintArray2D(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int rows = 5;
int colons = 7;
int[,] array2D = new int[rows, colons];
FillArray2D(array2D);
PrintArray2D(array2D);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine(SummDioganalArrya(array2D));
Console.ResetColor();