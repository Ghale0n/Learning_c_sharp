// Программа принимает число N и показывает все целые числа в промежутке от -N до N

//Сonsole.Clear();
Console.WriteLine("Привет! Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int X = (N * -1);
int index = X;
Console.Write(X);
while (index < N)
{
    X = X + 1;
    Console.Write(X);
    index++;
}