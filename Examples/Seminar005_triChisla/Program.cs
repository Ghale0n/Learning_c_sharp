// Программа принимает на вход 3 числа и показывает последюю цифру числа

Console.Clear();
Console.WriteLine("Привет! Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");