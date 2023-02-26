// апишите программу, которая выводит случайное трёхзначное число и 
//удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Random rnd = new Random();
int number = rnd.Next(100, 1000);
int firstNumber = (number / 100) * 10;
int lastNumber = number % 10;
int result = firstNumber+lastNumber;
System.Console.WriteLine(number);
System.Console.WriteLine(result);