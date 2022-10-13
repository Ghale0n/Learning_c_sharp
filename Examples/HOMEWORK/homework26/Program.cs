// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Stepen(int x, int step)

{
    
    int pro = x;
    for (int i = 1; i < step; i++)
    {
        pro *= x;
    }
    return pro;
}

Console.Clear();
Console.WriteLine("Введите число А: ");
int q = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int w = int.Parse(Console.ReadLine()!);

int result = Stepen(q, w);
Console.Write($"Число А в степени В = {result}");
