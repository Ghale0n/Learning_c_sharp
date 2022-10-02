// напиши программу, которая принимает на вход 2 числа и проверяет является ли одно число квадратом второго

Console.Clear();
Console.WriteLine("Привет! Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);

if (y * y == x)
{
    Console.WriteLine("Да, это квадрат!");
}
else
{
    Console.WriteLine("Нет, это ошибка");
}




