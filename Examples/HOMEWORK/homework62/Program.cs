// Заполните спирально массив 4 на 4.

int[,] ArrangeQuadroArray()
{
    int s = 4;
    int[,] array = new int[s, s];
    int i = 0; 
    int j = 0;
    int num = 1;

    for (int n = 1; n < 16; n++)
    {
        int k = 0;
        for (k = 0; k < s - 1; k++) array[i, j++] = num++;
        for (k = 0; k < s - 1; k++) array[i++, j] = num++;
        for (k = 0; k < s - 1; k++) array[i, j--] = num++;
        for (k = 0; k < s - 1; k++) array[i--, j] = num++;
        ++i; 
        ++j;
        s = s / 2;
    }
    return array;
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
Console.Clear();
Print2Array(ArrangeQuadroArray());