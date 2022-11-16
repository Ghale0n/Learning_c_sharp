// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSummBetween(int n, int m)
{
    if (n == m)
    {
        return m;
    }
    return n + GetSummBetween(n + 1, m);
}


Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма натуральных элементов в промежутке двух введенных чисел: {GetSummBetween(n, m)}");