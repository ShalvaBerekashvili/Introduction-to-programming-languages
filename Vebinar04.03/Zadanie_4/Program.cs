// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
// чисел от 1 до N

System.Console.WriteLine("Прошу введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Результат: ");

for ( int b = 1; b <= a; b++)
{
    int result = (int) Math.Pow(b, 2);
    System.Console.Write(result + " ");
}