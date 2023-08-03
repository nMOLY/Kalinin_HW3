Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int i = 1;

if (N > 0)
{
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
else
{
    if (N == 0)
    {
        Console.WriteLine("Вы ввели 0, попробуйте еще раз");
    }
    while (i <= Math.Abs(N))
    {
        Console.WriteLine(-Math.Pow(i, 3));
        i++;
    }
}