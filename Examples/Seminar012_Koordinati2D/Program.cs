// Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,10
//A (7,-5); B (1,-1) -> 7,21

// формула рассчета расстояния: (нужно построить вектор) 

double Dist(int x1, int x2, int y1, int y2)
{
    double result;
    result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    //result = Math.Round(result, 2);
    return result;
}

Console.Clear();
Console.Write("Введите Х координаты A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Х координаты B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты B: ");
int by = int.Parse(Console.ReadLine()!);


Console.Write($"Длина отрезка AB: {Dist(ax, ay, bx, by):f2} ");