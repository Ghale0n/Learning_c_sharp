// 

Console.Clear();
Console.Write("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine()!);
switch (x)
{
    case 1:
    {
        Console.WriteLine("X > 0 и Y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine(" X < 0 , Y > 0 ");
        break;
    }
    case 3:
    {
        Console.WriteLine("X < 0 и Y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("X > 0 и Y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Вы ввели не то число!");
        break;
    }

}
/*
if (x == 1)
{
    Console.WriteLine("X > 0 и Y > 0");

}
else if (x == 2)
{
    Console.WriteLine(" X < 0 , Y > 0 ");
}
else if (x == 3)
{
    Console.WriteLine(" X < 0, y < 0 ");
}
else if (x == 4)
{
    Console.WriteLine(" X < 0 , Y > 0 ");
}
else
{
    Console.WriteLine("Вы ввели не то число!");
}
*/