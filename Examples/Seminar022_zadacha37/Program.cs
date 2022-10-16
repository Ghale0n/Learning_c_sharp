// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArrayFromString(string stringArray) //позволяет считывать и запоминать элементы из строки в массив
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        res[i] = int.Parse(numbers[i]);
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0)
    {
        size++;
    }

    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        result[size - 1] = array[array.Length / 2];
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите числа для массива через пробел: ");
string input = Console.ReadLine();
int[] numArray = GetArrayFromString(input);

int[] newArray = ResultArray(numArray);

//Console.WriteLine($"Произведение пар массива {numArray}: {newArray}"!);

Console.WriteLine(String.Join(", ", newArray));