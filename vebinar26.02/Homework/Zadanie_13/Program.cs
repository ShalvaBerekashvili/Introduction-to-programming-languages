// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

System.Console.WriteLine("Эта программа выводит третью цифру!"); // приветствие программы!
System.Console.WriteLine(" ");
System.Console.WriteLine("Прошу введите число: ");
System.Console.WriteLine(" ");

int thirdТumber = Convert.ToInt32(Console.ReadLine());
int index = (int) Math.Log10(thirdТumber) + 1; //Тут вычисляет сколько цифр в числе, и присватевает к index

if (index < 3) // Проверяем наличие третьей цыфры.
{
    System.Console.Write("Третьей цифры нет! ");
    System.Console.WriteLine("Ошибка!");
}

int enterNuber = thirdТumber.ToString()[2] - '0'; // Тут "отсекает" все лишнее и выадет цифру с индексом равное значению "a"

System.Console.Write("Результат: ");
System.Console.WriteLine(enterNuber);
