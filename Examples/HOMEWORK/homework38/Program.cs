// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76

int[] getArray(int size, int minValue, int maxValue) // функция задаёт массив со случайными числами 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] minMass(int[] array)
{
    
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if
        {

        }
    }

    Console.Write(diff);
    
    // int min = maxValue;
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if(array[i] > max)
    //     {
    //         array[i] = max;
    //     }
    //     if (array[i] < min)
    // }
}

Console.Clear();

int[] array = getArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));

int diff = 0;

foreach (int el in array)
{
    diff = int[]
}

