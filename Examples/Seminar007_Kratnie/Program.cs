﻿// Программа, которая принимает 2 числа на вход
// выводит - кратное ли второе число первому

Console.Clear();
int num = new Random().Next(10, 100);
int ber = new Random().Next(1, 10);
int result = num % ber;
if (result == 0)
{
    Console.WriteLine($"Число {num} кратно {ber}");
}
else
{
    Console.WriteLine($"Число {num} не кратно {ber}, остаток - {result}");
}