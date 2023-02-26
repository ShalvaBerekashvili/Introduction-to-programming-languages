// Нужно получить сумму от 2 в 0 до 2-х 10-й степени

int n = 2;
int sum = 0;
for (int i = 0; i<=10; i++)
{
    sum += (int) Math.Pow(n, i);
    
}
System.Console.WriteLine(sum);