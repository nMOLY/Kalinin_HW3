Console.WriteLine("Введите ваше число");
int N = int.Parse(Console.ReadLine());
string s = N.ToString();
if (s.Length == 5)
{
    if (s[0] == s[4] && s[1] == s[3])
    {
        Console.WriteLine("Да, число является палиндромом");
    }
    else
    {
        Console.WriteLine("Нет, число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}