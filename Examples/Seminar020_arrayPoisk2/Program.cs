// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

bool CheckElement(int[] array, int num) // проверяет есть ли элемент в массиве
{
    foreach (int el in array)
    {
        if (el == num)
        {
            return true;
        }
    }
    return false;
}

Console.Clear();
Console.WriteLine("Введите числа для массива через пробел: ");
string input = Console.ReadLine();
int[] arr = GetArrayFromString(input);

Console.WriteLine("Введите число для проверки массива: ");
int n = int.Parse(Console.ReadLine()!); 


if (CheckElement(arr, n))
{
    Console.Write("Есть такое");

}
else
{
    Console.Write("Нет такого");
}
