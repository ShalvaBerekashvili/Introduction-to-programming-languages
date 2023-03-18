// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
System.Console.WriteLine("**This program creates an array of 123 random numbers!**");
System.Console.WriteLine("**We can show the number of array elements in the selected range!**");
System.Console.Write("Enter the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the minimum value of the element: ");
int minimumRange = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the maximum value of the element: ");
int maximumRange = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[sizeArray];
System.Random rnd = new System.Random();
for(int i=0; i < newArray.Length; i++)
{
    newArray[i] = rnd.Next(5);
}
System.Console.Write("[ ");
for(int i = 0;i < newArray.Length; i++)
    {
        System.Console.Write($"{newArray[i]}, ");
    }
System.Console.Write($"{newArray[newArray.Length-1]}"); // Вывод значения масива
System.Console.WriteLine(" ]");

int count=0;
for(int i=0; i < newArray.Length; i++)
{
if(i > minimumRange && i < maximumRange)
count++;
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("Output the number of array elements: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.Write(count);
Console.ResetColor();