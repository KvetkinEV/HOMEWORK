double max, a, b, c;
Console.WriteLine("Введите первое число!");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число!");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число!");
c = Convert.ToDouble(Console.ReadLine());
max = a;
if (b > a)
max = b;
if (c > max)
max = c;
Console.WriteLine("max = " + max);
Console.ReadLine();

