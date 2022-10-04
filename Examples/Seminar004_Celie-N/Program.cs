// Программа принимает число N и показывает все целые числа в промежутке от -N до N

//Сonsole.Clear();
Console.WriteLine("Привет! Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int X = (N * -1);

while (X <= N)
{
    Console.Write($"{X} ");
    X = X + 1;
}