// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] getArray(int size, int minValue, int maxValue) // функция задаёт массив со случайными числами 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SummOfEverySecondIndex(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    return summ;
    
}


Console.Clear();

int[] arr = getArray(10, -100, 100);

Console.WriteLine(String.Join(" ", arr));

int result = SummOfEverySecondIndex(arr);

Console.WriteLine($"Сумма элементов на нечетных поциях: {result}");