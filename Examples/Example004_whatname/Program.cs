Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "маша")
{
    Console.WriteLine("Маша - писька!");
}    
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}