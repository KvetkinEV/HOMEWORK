double a, b;
Console.WriteLine("Введите первое число!");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число!");
b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
Console.WriteLine("max = " + a);
}
else
{
Console.WriteLine("max = " + b);
}
Console.ReadLine();
