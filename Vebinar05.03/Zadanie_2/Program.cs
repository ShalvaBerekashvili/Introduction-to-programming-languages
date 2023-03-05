// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Ведите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int index = (int) Math.Log10(b) + 1;

System.Console.Write(index);
