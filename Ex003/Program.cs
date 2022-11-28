Console.Write("Введите номер четверти ");
int quart = Convert.ToInt32(Console.ReadLine());
if (quart == 1)
{
    Console.WriteLine("Rande x > 0 && y > 0");
}
if (quart == 2)
{
    Console.WriteLine("Rande x > 0 && y < 0");
}
if (quart == 3)
{
    Console.WriteLine("Rande x < 0 && y > 0");
}
if (quart == 4)
{
    Console.WriteLine("Rande x < 0 && y < 0");
}

