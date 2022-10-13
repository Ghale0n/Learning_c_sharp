// Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе


int CountNumber(int a)
{
    int count = 0;
    if (a == 0 )
    {
        return 1; // count = 1
    }
    while (a != 0) 
    {
        count++;
        a = a / 10;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int result = CountNumber(x);
Console.WriteLine(result);