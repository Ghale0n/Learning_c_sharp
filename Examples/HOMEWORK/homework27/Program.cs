// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SummCifr(int x)
{
    int count = 0;
    for (int i = 0; x > 0; i++)
    {
        x = x%10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int w = int.Parse(Console.ReadLine()!);

int result = SummCifr(w);
Console.Write($"Число А в степени В = {result}");