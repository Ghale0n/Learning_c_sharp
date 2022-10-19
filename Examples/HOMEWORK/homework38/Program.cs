// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76

double[] getArray(int size, int minValue, int maxValue) // функция задаёт массив вещественных чисел благодаря double
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}

double maxMass(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

    }
    return max;
}


double minMass(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;

}
Console.Clear();

double[] newarr= getArray(5, -100, 100);
Console.WriteLine(String.Join(", ", newarr));

// int diff = 0; //попытка решить через сравнение

// foreach (int el in array)
// {
//     diff = int[]
// }

double Min = minMass(newarr);
double Max = maxMass(newarr);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Max - Min}");

