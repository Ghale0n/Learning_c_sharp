// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist(int x1, int x2, int y1, int y2, int z1, int z2)
//              ax      ay      bx      by      az      bz
{
    double result;
    result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    //result = Math.Round(result, 2);
    return result;
}

Console.Clear();
Console.Write("Введите Х координаты A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты A: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите Х координаты B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты B: ");
int by = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты B: ");
int bz = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина отрезка AB: {Dist(ax, ay, bx, by, az, bz):f2} "); //f2 - сокращет значение до второй цифры после запятой