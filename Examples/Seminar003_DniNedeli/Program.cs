// Пишем прогрраму, которая будет выдавать день недели по номеру

Console.Clear();
Console.WriteLine("Привет! Введи число от одного до семи: ");
int x = int.Parse(Console.ReadLine()!);

if (x == 1)
{
    Console.Write("Это понедельник!");
}
else if (x == 2)
{
    Console.Write("Это вторник!");
}
else if (x == 3)
{
    Console.Write("Это среда!");
}
else if (x == 4)
    {
        Console.Write("Это четвег!");
    }
else if (x == 5)
    {
        Console.Write("Это пятница!");
    }
else if (x == 6)
    {
        Console.Write("Это суббота!");
    }
else if (x == 7)
    {
        Console.Write("Это воскресенье!");
    }