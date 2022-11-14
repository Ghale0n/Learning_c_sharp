// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void minRow(int[,] inArray)
{
    int minSum = 0;
    int result = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum += inArray[0, j];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            tempSum += inArray[i, j];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            result = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}

Console.Clear();

Console.WriteLine("Перед вами прямоугльный массив 3 на 4:");
Console.WriteLine();
int[,] array = Get2Array(3, 4, 0, 10);
Print2Array(array);
Console.WriteLine();
minRow(array);