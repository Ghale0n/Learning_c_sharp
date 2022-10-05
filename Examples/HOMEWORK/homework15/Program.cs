// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// ТУТ У МЕНЯ ДВА РЕШЕНИЯ - ДЛИННОЕ И КОРОТКОЕ В КОНЦЕ - ОБА РАБОЧИЕ

Console.Clear();
Console.WriteLine("Привет! Введи число от одного до семи, соответсвующее дню недели: ");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
    Console.Write("Это понедельник!");
    Console.WriteLine("Понедельник - будний день!");
}
else if (x == 2)
{
    Console.Write("Это вторник!");
    Console.WriteLine("Вторник - будний день!");
}
else if (x == 3)
{
    Console.Write("Это среда!");
    Console.WriteLine("Среда - будний день!");
}
else if (x == 4)
{
    Console.Write("Это четвег!");
    Console.WriteLine("Четверг - будний день!");
}
else if (x == 5)
{
    Console.Write("Это пятница!");
    Console.WriteLine("Пятница - будний день!");
}
else if (x == 6)
{
    Console.WriteLine("Это суббота!");
    Console.WriteLine("Суббота - выходной!");
}
else if (x == 7)
{
    Console.WriteLine("Это воскресенье!");
    Console.WriteLine("Воскресенье - выходной!");
}

/*
if(x == 6 || x == 7)
{
    Console.WriteLine("Это выходной день");
}
if(x == 1|| x == 2|| x == 3|| x == 4|| x == 5)
{
    Console.WriteLine("Это будний день");
}
*/