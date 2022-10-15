// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] getArray(int size, int minValue, int maxValue) // функция задаёт массив со случайными числами 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ArrayMinus(int[] array) // умножнает массив на -1
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}


Console.Clear();

int[] array = getArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));

ArrayMinus(array);
Console.WriteLine(String.Join(", ", array));


