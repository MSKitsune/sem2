Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int res1 = 0;
int res2 = 0;

if (num < 10 && num > 99)
{
    Console.WriteLine("ошибка");
}
    res1 = num % 10;
    res2 = num / 10;
    if (res1 > res2)
    {
        Console.WriteLine(res1);
    }
    else
    {
        Console.WriteLine(res2);
    }