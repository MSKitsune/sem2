int num = new Random().Next(0,10000);
Console.WriteLine(num);
int res = 0;
while (num >= 10)
{
    res = num % 10;
    num/=10;
    Console.WriteLine(res + ", ");
}
res = num % 10;
Console.WriteLine(res);
