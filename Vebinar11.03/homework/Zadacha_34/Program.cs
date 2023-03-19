/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[] EnterLengthArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }
            return array;
        }

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                System.Console.Write($"{array[i],4}");
            }
        }

        int FindEvenNumbersInAnArray(int[] evenNumbers)
        {
            int counter = 0;
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                if (evenNumbers[i] % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        System.Console.WriteLine("Output of the filled array: ");
        int[] array = EnterLengthArray(10);
        PrintArray(array);
        System.Console.WriteLine(" ");
        System.Console.Write($"The number of even numbers in the array  {FindEvenNumbersInAnArray(array)}");
    }
}