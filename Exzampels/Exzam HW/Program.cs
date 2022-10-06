int a = 0;
int b = 0;
Console.WriteLine("введите число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
Console.WriteLine(" число a больше числа b");
}
else if (a<b)
{
    Console.WriteLine("число a меньше числа b");
}