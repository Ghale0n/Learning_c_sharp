

Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
//int a2 = num / 10;
int a3 = num % 10;

Console.WriteLine($"первая цифра числа {num} - {a1}, а третья - {a3}");