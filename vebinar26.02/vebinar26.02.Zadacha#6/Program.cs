// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool isSquare = Math.Pow(firstNumber, 2)==secondNumber || Math.Pow(secondNumber, 2)==firstNumber;
if (isSquare)
    System.Console.WriteLine("da");
else
    System.Console.WriteLine("net");