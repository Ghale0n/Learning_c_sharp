//ВИДЫ МЕТОДОВ

//1 группа методов

void Method1()
{
    Console.WriteLine("Автор текста: ");
}
//Method1();

//2 группа методов

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Message text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("TEXT", 2);
// Method21(count: 4, msg "NEW TEXT");

// 3 группа методов

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// 4 группа методов

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "WOW");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    
    string result = string.Empty;
for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "WOW");
Console.WriteLine(res);