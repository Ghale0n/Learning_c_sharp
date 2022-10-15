// Программа задаёт массив из 8 символов и выводит их на экран


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


void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();
Console.WriteLine("Введите 8 чисел через пробел для создания массива: ");
string numbers = Console.ReadLine()!;

int[] ArrayResult = GetArrayFromString(numbers);

if (ArrayResult.Length != 8)
{
    Console.Write("Введите число,соответствующее условию");

}
else
{
    PrintArr(ArrayResult);
}



