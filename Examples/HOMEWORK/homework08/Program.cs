// задача на вывод всех четных чисел от одного до n

Console.Clear();
Console.WriteLine("Привет! Крайняя задача на сегодня, ура! Введи число: ");
int n = int.Parse(Console.ReadLine()!);

int index = 2;
while (index <= n)
{
    Console.Write($"{index} ");
    index = index + 2;
}

