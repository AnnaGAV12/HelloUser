Console.Write("input digit A ");
int a = int.Parse(Console.ReadLine());
int b = -a;
while (b <= a)
{
    Console.Write(b);
    b = b + 1;
}