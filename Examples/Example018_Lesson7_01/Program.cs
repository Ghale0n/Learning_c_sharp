//Собрать строку с числами от a до b, a<=b

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b ; i++) // если делать в обратную сторону, то условие цикла for (int i = a; i >= b; i i--);
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) //метод того же самого  с рекурсией
{
    if (a<=b) return $"{a} " + NumbersRec(a+1, b); // если делать в обратную сторону, то if (a<=b) return NumbersRes(a + 1 , b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));

Console.WriteLine(NumbersRec(1, 10));