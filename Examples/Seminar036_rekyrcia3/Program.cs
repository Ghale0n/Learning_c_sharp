// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int GetSquare(int i, int j)
{
    if(j == 0)
    {
        return 1;
    }
    return i *  GetSquare(i, j - 1);
}

Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Число {n} в степени {m} равно {GetSquare(n, m)}");