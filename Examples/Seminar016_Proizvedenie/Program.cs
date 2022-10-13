// Программа принимает на вход число N и выдаёт произведение чисел от 1 до N


int Proizvedenie(int A)
{
    int pro = 1;

    for (int i = 1; i <= A; i++)
    {
        pro = pro* i; // sum = sum + i;
    }
    return pro;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int result = Proizvedenie(N);
Console.Write(result);