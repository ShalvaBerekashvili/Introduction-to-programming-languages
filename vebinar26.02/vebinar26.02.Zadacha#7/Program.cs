// дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

int n = Convert.ToInt32(Console.RadLine());
float sum = 0;
for (int i = 1; i<=n; i++)
{
    sum += (float) 1 / (float) i;
    System.Console.WriteLine((float) 1 / (float) i);
}
