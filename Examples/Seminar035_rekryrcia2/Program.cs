// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int GetSummN(int n)
{
    if (n == 0)
    {
        return 0;
    }
    //Console.WriteLine($"F({start}, {end}) -> {start + " " + GetSummN(start + 1, end)}");
    return n % 10 + GetSummN(n / 10);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Сумма чисел числа {m}: {GetSummN(m)}");