// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

// int[,] ChetniyElSquare(int[,] array, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }

//     return array;
// }

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

void ChetniyElSquare(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                inArray[i, j] = inArray[i, j] * inArray[i, j];
            }
            // Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns,0, 20);
Print2Array(array);
ChetniyElSquare(array);
Print2Array(array);