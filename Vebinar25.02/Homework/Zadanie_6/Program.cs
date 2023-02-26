// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число: ");
int chetnyNumber = Convert.ToInt32(Console.ReadLine());

if (chetnyNumber % 2 == 0)
{
    System.Console.Write("Результат: ");
    System.Console.WriteLine("Yes");  
}
else
{
    System.Console.Write("Результат: ");
    System.Console.WriteLine("no");
}