// 1)Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36



int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = InputNumberWithMessage("Введите A");

int summ = 0;

for (int i = 1; i <= A; i++)
{
    summ += i;
}

System.Console.WriteLine(summ);


//////////////////////////////////////////////////
// тут описано реализовано решение через функцию InputNumberWithMessage

// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SummDigitsInNumber(int number)
// {
//     int summ = 0;

//     for (int i = 1; i <= number; i++)
//     {
//         summ += i;
//     }

//     return summ;
// }
// int A = InputNumberWithMessage("Введите A");

// System.Console.WriteLine(SummDigitsInNumber(A));

