// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void VocabCount(int[] inArray)
{
    int count = 1;
    int numberZero = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
            if(inArray[i] == numberZero)
            {
                count++;
            }
            else
            {
                Console.WriteLine($"Число {numberZero} встречается {count} раз");
                numberZero = inArray[i];
                count = 1;
            }
        }
    }

int[] BinaryToSingle(int[,]inArray)
{
    int[] result = new int [inArray.GetLength(0)*inArray.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           result[k++] = inArray[i,j]; 
        }
    }
    return result;
    
}

void sortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length; j++)
        {
            if(inArray[i] >inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = Get2Array(row, columns,0, 10);
int[] array1d = BinaryToSingle(array);
Print2Array(array);
Console.WriteLine();

sortArray(array1d);
VocabCount(array1d);
