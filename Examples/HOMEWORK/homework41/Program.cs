// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

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

int SummPositive (int[] array)
{
    int summ = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            summ ++;
        }
    }
    return summ;
}

Console.Clear();

Console.WriteLine("Введите ряд чисел через пробел: ");
string x = Console.ReadLine()!;

int[] result = GetArrayFromString(x);

int Summ = SummPositive(result);

Console.WriteLine($"Количество чисел > 0: {Summ}");
