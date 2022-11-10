// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.

int[,] Get2Array(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}


void Print2Array(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int SummMainLine(int[,] inArray)
{
    int summ = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j) 
            {
                summ = summ + inArray[i,j];
            }
        }
    }
    return summ;
}


Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns,0, 20);
Print2Array(array);
Console.WriteLine($"Сумма чисел по индексам главной диагонали: {SummMainLine(array)}");