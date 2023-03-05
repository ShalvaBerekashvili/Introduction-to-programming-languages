// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
System.Console.WriteLine("Прошу введите, порядковый номер дня недели: ");
int dailOfWeek = Convert.ToInt32(Console.ReadLine());
 while (true) 
{ 
    if (dailOfWeek >= 1 && dailOfWeek <= 5) 
        { 
            Console.Write(" Нет, это не выходной");
            break; 
        } 
        else if (dailOfWeek >= 6 && dailOfWeek <= 7) 
        { 
            Console.Write(" Да, это выходной");
            break; 
        } 
        
    else Console.Write(" Не существует такого дня недели");
    break; 
}