// программа вывода факториала (РЕКУРСИЯ - программа, которая обращается сама к себе)

double Factorial(int n)
{
    // факториал 1! = 1
    // факториал 0! = 1
    if (n == 1) return 1;
    else 
    {
        return n * Factorial(n - 1);
    }
}

Console.WriteLine(Factorial(17)); // 3!= 3 * 2 * 1 ==6