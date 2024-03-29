﻿// Метод void - это метод который не возвращает занчение эллемента.

// Для заполнения масива необходимо создать/восполльзоваться методом.
// Ключевое слово void, далее наименование метода FillArray, int [] collection - тело аргумента.
void FillArray(int [] collection)
{
    int length = collection.Length; // Получаем длину массива при помощи collection.Length
    int index = 0; // Тут задается позиция index по умолчанию/
    while (index < length) // Цикл while пока  index меньше length, будет повторять цикл.
    {
        // Обращаемся на к аргументу collection, на позицию index, и положить тудя новое случайное целое число
        // При помощи генератора случайных чисел new Random() из диапазона .Next(1, 10);
        collection[index] = new Random().Next(1, 10);       
        // index = index + 1; - Раширенный вариант записи, при каждом прохождении цикла занчение index увеличивается на еденицу.
        index++; // - Так принято на языке C#, сокращенный вариант записи, при каждом прохождении цикла занчение index увеличивается на еденицу.
    }
}
// Создаем void который будет печатать массив, задаем новое имя аргументу - col.
void PrintArray(int [] col)
{
    // Обозначаем количество элементов, следующим образом
    int count = col.Length;
    int position = 0; // Тут наименование позиции указываем не через index, а через position.
    while (position < count)
    //Берем новый цикл while, пока position мнеьше count, 
    //будет выводиться на экран/консоль значение теущего элемнета.
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод поиска
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // дословно, создай новый массив с десятью элементами, но он будет наполнен нулями.

FillArray(array);
PrintArray(array);
// Определили массив из десяти элементов,далее вызывали метод FillArray который заполнил массив
// Далее вызвали метод, PrintArray который его распечатал. 

System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine("Вывод номера позиции(index) числа: ");
System.Console.WriteLine(pos);