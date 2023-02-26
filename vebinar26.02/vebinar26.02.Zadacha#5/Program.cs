// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
// &&


int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % secondNumber == 0)
    System.Console.WriteLine("кратно");
else
    System.Console.WriteLine($"не кратно= {firstNumber % secondNumber}");