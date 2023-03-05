// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int MultiplicationDigitsInNumber(int number)
// {
//     int pr = 1;
//     while (number > 0 )
//     {
//         pr *= number % 10;
//         number /= 10;
//     }
//     return pr;
// }
// int N = InputNumberWithMessage("Введите число");
// System.Console.WriteLine(MultiplicationDigitsInNumber(N));


// 3)Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120


int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int MultiplicationDigitsInNumber(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
int N = InputNumberWithMessage("Введите число");
System.Console.WriteLine(MultiplicationDigitsInNumber(N));
