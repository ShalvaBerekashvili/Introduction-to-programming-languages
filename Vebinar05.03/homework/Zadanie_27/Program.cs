﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Добро пожаловать, данная программа выполняет сложение всех цифр в числе"); // Приветсвие программы.
System.Console.WriteLine("Прошу введите число: "); // Приглошение для пользователя ко вводу числа
int FreeNumber = Convert.ToInt32(Console.ReadLine()); // Строка для ввода значения, в данном случае - чисел.
int i = 0; // Значение перменной по умолчанию
while (FreeNumber != 0) // Пока FreeNumber не будет равен нулю, цикл продолжается
{
    i += (FreeNumber % 10); // Тут складываем изночальное значениt i и последнию цифру числа, затем путем складваня присваиваем новое значение 
    FreeNumber = FreeNumber / 10; // Тут идет процес "отсекания" последней цифры в числе, путем деления на 10. десятичная часть округляется до целого.
}

System.Console.WriteLine("Результат вычесленией: " + i);