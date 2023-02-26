//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b*b == a)
{
    System.Console.WriteLine("DA");
}
else
{
    System.Console.WriteLine("NET");
}