// Прога на ввод трехзначного числа, а на выходе показывает второе число

Console.Clear();
Console.WriteLine("Привет! Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine()!);
int first = x / 100; //первая цифра числа без остатка
first = first * 100;
int third = x%10;
int result1 = (x - first - third)/10;

Console.WriteLine($"Второе число из трехзначного - {result1}");