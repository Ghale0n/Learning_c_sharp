// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Привет! Введите число: ");
int x = int.Parse(Console.ReadLine()!);

/*int res1 = x % 10; // последняя цифра числа
int res2 = x / 10; //результат целочисленного деления на 10

Console.WriteLine($"последняя цифра числа- {res1}");
Console.WriteLine($"результат целочисленного деления на 10 - {res2}");
*/

while (x > 0)
{
    if (x <= 99)
    {
        Console.WriteLine("Нет третьего числа");
        break;
    }
    if (x <= 999)
    {
        x = x % 10;
        Console.WriteLine($"Третье по счету число: {x}");
        break;
    }
    x = x / 10;



}



// Тут я переусложнил себе задачу, решив, что по дано пользователь должен задавать индекс искомого числа

// Console.WriteLine("Привет! Введите индекс числа: "); 
// int index = int.Parse(Console.ReadLine()!);
// int[] array = {x};
// int[] array = new int[x];
// int n = array.Length;
// index = n;
/*int index = 10;
while (x >= x % 100)
{
x = x / index;
Console.Write("делим");
//break;


if (x >= 100)
{
    Console.WriteLine("ТУТ ДОЛЖЕН БЫТЬ ОТВЕТ");
}

if (x < 100)
{
    Console.WriteLine("Нет третьего числа");
}
index++;
}
// Console.WriteLine($"третья цифра числа {x} - это {result} !");
*/