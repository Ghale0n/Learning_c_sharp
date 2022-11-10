
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// new Random().NextDouble() * (b - a) + a; - удобная формула задачи массива


double[,] Get2ArrayDouble(int m, int n, double maxValue, double minValue)
{
    double[,] Double2Array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Double2Array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return Double2Array;
}


void Print2ArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное число для массива: ");
double minValue = double.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число для массива: ");
double maxValue = double.Parse(Console.ReadLine()!);

double[,] array = Get2ArrayDouble(rows, columns, maxValue, minValue);
Print2ArrayDouble(array);