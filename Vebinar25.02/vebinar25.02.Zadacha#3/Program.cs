//Напишите программу, которая будет выдавать название дня недели по 
//заданному номеру
System.Console.WriteLine("Прошу введите, порядковый номер дня недели: ");
int dailOfWeek = Convert.ToInt32(Console.ReadLine());
if (dailOfWeek == 1)
{
    System.Console.WriteLine("Monday");
}
else if (dailOfWeek == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (dailOfWeek == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (dailOfWeek == 4)
{
    System.Console.WriteLine("Thuraday");
}
else if (dailOfWeek == 5)
{
    System.Console.WriteLine("Friday");
}
else if (dailOfWeek == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (dailOfWeek == 7)
{
    System.Console.WriteLine("Sunday");
}
else if (dailOfWeek == 8)
{
    System.Console.WriteLine("Error");
}