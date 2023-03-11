// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int size = 12;
int[] array = new int[size];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-9, 10);
}

Console.WriteLine(string.Join(",", array));

(int moreThanZero, int lessThanZero) amounts = (0, 0);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        amounts.moreThanZero += array[i];
    else
        amounts.lessThanZero += array[i];
}

System.Console.WriteLine($"Больше 0 = {amounts.moreThanZero}, меньше 0 = {amounts.lessThanZero},");