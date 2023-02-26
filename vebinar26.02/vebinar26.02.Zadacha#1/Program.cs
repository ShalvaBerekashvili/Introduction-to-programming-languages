// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();

Random rnd = new Random(); 
int number = rnd.Next(1, 100);

int firstDigit = number / 10;
int lastDigit = number % 10;
int maxDigit = Math.Max(firstDigit, lastDigit);

System.Console.WriteLine(number);
System.Console.WriteLine(maxDigit);