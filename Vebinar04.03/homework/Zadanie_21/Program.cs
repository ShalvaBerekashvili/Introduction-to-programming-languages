// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Координаты №1
System.Console.WriteLine("Прошу введите X1: "); // Приглошение для ввода числа 
double a = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа
System.Console.WriteLine("Проушу введите Y1: "); // Приглошение для ввода числа
double b = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа
System.Console.WriteLine("Проушу введите Z1: "); // Приглошение для ввода числа
double c = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа

// Координаты №2
System.Console.WriteLine("Проушу введите X2: "); // Приглошение для ввода числа
double d = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа
System.Console.WriteLine("Проушу введите Y2: "); // Приглошение для ввода числа
double e = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа
System.Console.WriteLine("Проушу введите Z2: "); // Приглошение для ввода числа
double f = Convert.ToDouble(Console.ReadLine()); // Присвоение переменой вводимого числа

double lengthX = Math.Pow(d-a, 2); // Вычесление квадрата разницы чисел по оси Х, и присвоение этого значений переменой
double lengthY = Math.Pow(e-b, 2); // Вычесление квадрата разницы чисел по оси Y, и присвоение этого значений переменой
double lengthZ = Math.Pow(f-c, 2); // Вычесление квадрата разницы чисел по оси Z, и присвоение этого значений переменой

double result = Math.Round(Math.Sqrt(lengthX + lengthY + lengthZ), 2); // Вычесление квадрата сумм значений всех осей.

System.Console.Write("Растояние: " + result);