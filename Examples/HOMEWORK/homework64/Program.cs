// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetReversePrint(int start, int end)
{
    if(end == start)
    {
        return end.ToString();
    }
    Console.WriteLine($"F({end}, {start}) -> {start + " " + GetReversePrint(start + 1, end)}");
    return end + " " + GetReversePrint(start, end - 1);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.Write(GetReversePrint(m, n));