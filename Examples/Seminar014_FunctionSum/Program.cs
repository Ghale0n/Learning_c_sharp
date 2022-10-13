// напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А

// int GetSumm(int A)
// {
//     int sum = 0;

//     for (int i = 0; i <= A; i++) ;
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// GetSumm(n);

int GetSum(int A)
{
    int sum = 0;

    for (int i = 0; i <= A; i++)
    {
        sum += i; // sum = sum + i;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите А: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n));