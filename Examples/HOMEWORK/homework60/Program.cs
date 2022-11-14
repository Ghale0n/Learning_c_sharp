// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int[,,] Get3Array(int a, int b, int c, int minValue, int maxValue)
{
    int[,,] array3D = new int[a, b, c];
    int[] temp = new int[a * b * c]; // будем проверять и заполнять 3D массив с помощью одномерного
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j]) // проверка уникальности значений
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; // заполнение 3D массива
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
    return array3D;
}

void print3Array(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int n = 0; n < inArray.GetLength(2); n++)
            {
                Console.Write($"{inArray[i, j, n]}({i},{j},{n}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер трёхмерного массива (X, Y, Z): ");
Console.WriteLine();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine()!);
Console.WriteLine();
if (x * y * z > 90) Console.WriteLine("Вы ввели слишком большой массив, система подвиснет");
else
{
    int[,,] array = Get3Array(x, y, z, 10, 100);
    print3Array(array);
}