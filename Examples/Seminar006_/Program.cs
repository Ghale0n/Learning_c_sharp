// программа выводит случайное число из отрезка [10 , 99] 
// и показывает наибольшую цифру числа

Console.Clear();
// [ ] - отрезок [ ) - полуинтервал(не включает последнее)
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if(max <a2)
{
    max = a2;
}
Console.WriteLine("max");