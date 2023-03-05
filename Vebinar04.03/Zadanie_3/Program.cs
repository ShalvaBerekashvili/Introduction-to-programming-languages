// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

// Координаты №1
System.Console.WriteLine("Прошу введите X: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Проуш введите Y: ");
double b = Convert.ToDouble(Console.ReadLine());
// Координаты №2
System.Console.WriteLine("Проуш введите X: ");
double c = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Проуш введите Y: ");
double d = Convert.ToDouble(Console.ReadLine());

double lengthX = Math.Pow(c-a, 2);
double lengthY = Math.Pow(d-b, 2);

double result = Math.Round(Math.Sqrt(lengthX + lengthY), 2);

System.Console.Write("Растояние: " + result);