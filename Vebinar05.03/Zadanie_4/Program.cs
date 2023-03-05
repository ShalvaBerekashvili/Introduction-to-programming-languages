// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] mass = new int[8];
Random rnd = new Random();

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(0, 2);
}

for (int i = 0; i < mass.Length; i++)
{
    if (i == mass.Length - 1)
        System.Console.Write(mass[i]);
    else
        System.Console.Write(mass[i] + ", ");




}

// через фукцию 

// void FillingAnArrayWithRandomNumbers(Array arr, Random rnd)
// {
//    for (int i = 0; i < arr.Length; i++)
//    {
//         arr[i] = rnd.Next(0, 1);
//    }
// }

// int[] arr = new int[8];
// Random rnd = new Random();
// FillingAnArrayWithRandomNumbers(arr, rnd);

// Console.WriteLine(String.Join(",", array));



// //////
// void FillArrayRandomNumbers(int[] array)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//             System.Console.Write(array[i]);
//         else
//             System.Console.Write(array[i] + ", ");
//     }
// }

// int[] mass = new int[8];
// FillArrayRandomNumbers(mass);
// PrintArray(mass);


