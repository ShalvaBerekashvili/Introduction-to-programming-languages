//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
int a = Convert.ToInt32(Console.ReadLine());
int b = a * -1;

while (b <= a)
{
    System.Console.WriteLine(b);
    b += 1;
}