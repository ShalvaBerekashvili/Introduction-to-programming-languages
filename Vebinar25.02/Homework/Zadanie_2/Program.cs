//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

System.Console.WriteLine("Программа для обпределения из двух чисел, наименьшего и наибольшего!");
System.Console.WriteLine("Прошу вести певое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Прошу вести второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if ( a < b ) // исходя из задания и примеров, пришел выводу что необходимо выводить наибольшее число.
{
    System.Console.Write("Наибольшее число: ");
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine(а);
}