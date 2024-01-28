Console.Write("введите значение n = ");
int n = int.Parse(Console.ReadLine());
double s1 = 0;
for (int i = 0; i <= n; i++)
{
    double s2 = 0;
    for (int j = 0; j <= n; j++)
    {
        s2 = s2+ Math.Pow(i, 2) - 2 * j;
        Console.WriteLine($"s2= {s2}");
    }
    s1 = s1+s2;
}
Console.WriteLine($"s={s1}");