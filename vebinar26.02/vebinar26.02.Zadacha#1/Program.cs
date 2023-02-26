// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();

Random rnd = new Random(); 
int number = rnd.Next(1, 100);

System.Console.WriteLine(number);