// Вввод 3х чисел и вывод максимально

Console.Clear();
Console.WriteLine("Привет! Введи первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("А теперь второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ну и третье число: ");
int z = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"в сумме это будет: {x + y + z}"); (Лирическое отступление)

if (x > y)
{
    if (x > z)
    {
        Console.WriteLine($"Самое большое число - {x}");
    }

}
else
{
    if (y > z)
    {
        Console.WriteLine($"Самое большое число - {y}");
    }
    else
        Console.WriteLine($"Самое большое число - {z}");
}

// ИЗНАЧАЛЬНО ПЫТАЛСЯ СРАВНИТЬ КАЖДОЕ С КАЖДЫМ ЧЕРЕЗ ELSE IF, НО В ОТВЕТЕ ВСЕГДА ВЫДАВАЛО ПО ДВА ЧИСЛА ПОЧЕМУ-ТО
//    else if (y > z) 
//{
//    Console.WriteLine($"Самое большое число - {x}");
//}
//if (y > z)
//{
//    Console.WriteLine($"Самое большое число - {y}");
//}
//    else if (z > x)
//{
//    Console.WriteLine($"Самое большое число - {y}");
//}
//if (z > y)
//{
//    Console.WriteLine($"Самое большое число - {z}");
//}
//    else if (y > x)
//{
//    Console.WriteLine($"Самое большое число - {z}");
//}