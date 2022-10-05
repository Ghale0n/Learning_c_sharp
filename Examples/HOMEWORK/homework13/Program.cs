// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Привет! Введите число: ");
int x = int.Parse(Console.ReadLine()!);

// Тут я переусложнил себе задачу, решив, что по дано пользователь должен задавать индекс искомого числа

// Console.WriteLine("Привет! Введите индекс числа: "); 
// int index = int.Parse(Console.ReadLine()!);
// int[] array = {x};
// int[] array = new int[x];
// int n = array.Length;
// index = n;

while (x >= x % 100)
{
    x / 10;
    Console.Write("111");
    break;
}

if (x >= 100)
{
    Console.WriteLine("ТУТ ДОЛЖЕН БЫТЬ ОТВЕТ");
}

if (x < 100)
{
    Console.WriteLine("Нет третьего числа");
}

// Console.WriteLine($"третья цифра числа {x} - это {result} !");