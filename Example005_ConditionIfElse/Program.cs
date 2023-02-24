Cosole.Write("Введите имя пользователя"); // так и не заработало !()
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}