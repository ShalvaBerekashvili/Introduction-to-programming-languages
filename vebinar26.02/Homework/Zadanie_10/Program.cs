// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа

System.Console.WriteLine("Enter a three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = (a % 100) / 10;

System.Console.Write("Result: ");
System.Console.WriteLine(b);