// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

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

// double SredneeInRows(int[,] inArray)
// {
//     double sred = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)

//         {
//             sred += sred[i,j] / inArray.GetLength(1);
//         }
//     }
//     return sred;
// }



// метод вывода среднего арифмитического в столбцах массива:
void AverageOfColumns(int[,] array)
{
    double sum = 0;
    double[] result = new double[array.GetLength(1)]; // создаю массив по размеру равный количеству столбцов.

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round(sum / array.GetLength(0), 2); //делю сумму чисел в столбце на количество строк (т.е. на количество чисел в столбце) и записываю результат в мой созданный массив.
    }
    Console.WriteLine($"[{String.Join("; ", result)}]");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns, 0, 20);
Print2Array(array);

// Console.WriteLine($"Сумма чисел в столбце: {SredneeInRows(array)}");

Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
AverageOfColumns(array);