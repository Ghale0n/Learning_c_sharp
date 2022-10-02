// Задача на проверку четности вводимого числа

Console.Clear();
Console.WriteLine("Привет! Введи число: ");
int x = int.Parse(Console.ReadLine()!);
if (x % 2 == 0)
{
    Console.Write("Ура, число четное");
}
else
{
    Console.Write("Число нечетное");
}
