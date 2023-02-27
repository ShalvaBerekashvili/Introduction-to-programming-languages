// Функция по нахождению index числа из масива.
int [] array = { 1, 2, 3, 4, 5, 2, 23, 33, 43, 23, 432, 32, 1};

int n = array.Length; // Возврящает длинну масива или все элементы массива.
System.Console.WriteLine("Ведите число, которое необходимо найти: ");
int a = Convert.ToInt32(Console.ReadLine());
int find = a;

int index = 0; // некоторый счетчик

while (index < n)
{
    if(array[index] == find) // если array софпадает с findто программа завершает работу.
    {
        System.Console.WriteLine("Число найдено, его index: ");
        System.Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}


