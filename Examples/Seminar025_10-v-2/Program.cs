// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// для того чтобы преобразовать из 10 в двоичную систему необходимо делить на два и дальше делить остаток, 
// после чего записать в развёрнутом порядке

string NewMass(int a)
{
string arr = "";
while (a > 0)
{
arr += (a % 2).ToString(); // метод преобразовывает число в строку
a /= 2;
}
return arr;
}

int MassRev(string arr)
{
string result = "";

for (int i = 0; i < arr.Length; i++)
{
result += arr[arr.Length-1-i]; // функция переворачивает массив
}
return int.Parse(result);
}

Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

string arr = NewMass(num);

int num1 = MassRev(arr);
Console.WriteLine($"В двоичном виде - {num1}");