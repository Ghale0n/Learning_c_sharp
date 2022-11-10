// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

// void ChangeLine2Row(int[,] inArray)
// {
//     if (inArray.GetLength(0) != inArray.GetLength(1)) Console.Write("Операция невозможна");
//     int temp;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             inArray[i,j] = inArray[j ,i];
//             temp = inArray[j,i];
//         }
//     }
// }

int[,] ChangeLines2Rows(int[,] inArray)
{
    if (inArray.GetLength(0) != inArray.GetLength(1)) Console.Write("Операция невозможна");
    int[,] resultArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            resultArray[i, j] = inArray[j, i];
        }
    }
    return resultArray;
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns, 0, 20);
Print2Array(array);
int[,] result = ChangeLines2Rows(array);
Console.WriteLine();
Print2Array(result);