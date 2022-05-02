Console.Write("Введите 3х-значное число ");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
    Console.Write("Последняя цифра ");
    Console.WriteLine(a % 10);
}
else
{
    Console.Write("Число не 3х-значное");
}