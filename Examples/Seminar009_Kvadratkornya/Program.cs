// программа принимает 2 числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Проверка квадратного корня");
Console.WriteLine("Введите число один: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число два: ");
int ber = int.Parse(Console.ReadLine()!);

if (num * num == ber || ber * ber == num)
{
    Console.WriteLine("Да!");
}
else 
{
    Console.WriteLine("Нет!");
}