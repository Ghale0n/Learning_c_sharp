// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

// метод упорядочивания строк двумерного массива по убыванию
int[,] Sort2DArrayRowsFromMaxtoMin(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int sortedj = j + 1;
            for (sortedj = j + 1; sortedj < inArray.GetLength(1); sortedj++)
            {
                if (inArray[i, j] < inArray[i, sortedj])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, sortedj];
                    inArray[i, sortedj] = temp;
                }
            }
        }
    }
    return inArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns,0, 10);
Print2Array(array);
Console.WriteLine();
int[,] result = Sort2DArrayRowsFromMaxtoMin(array);
Print2Array(result);