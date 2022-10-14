// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int CountCifri(int x)
{
    int count = 0;
    for (int i = 1; x > 0; i++)
    {
        count = count + x%10;
        x = x/10;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите число Х : ");
int X = int.Parse(Console.ReadLine()!);

int result = CountCifri(X);
Console.Write($"Сумма всех цифр числа X: {result}");