// задача на вывод всех четных чисел от одного до n

Console.Clear();
Console.WriteLine("Привет! Крайняя задача на сегодня, ура! Введи число: ");
int n = int.Parse(Console.ReadLine()!);
int x = 1;
int index = 1;
while (index <= n)
{
    if (index % 2 == 0)
    {
        x = index;
        Console.Write($"{x} ");
    }
    index = index + 1;
}

