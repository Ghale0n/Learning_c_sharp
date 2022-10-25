// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void Crossing(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine($"Прямые не пересекаются");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        x = Math.Round(x, 1);
        y = Math.Round(y, 1);
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
    }
}

Console.Clear();
Console.Write("Введите первое число для координат прямой (b1): ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число для координат прямой (k1): ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите третье число для кооординат прямой (b2): ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число для координат прямой (k2): ");
double k2 = double.Parse(Console.ReadLine()!);

Crossing(b1, k1, b2, k2);