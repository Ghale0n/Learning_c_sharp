// Напишите пограмму, которая выводит массив из восьми элементов заполненный нулями и единицами
// в случайном порядка


int[] RandomArr()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;

}
void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1) 
        {
            Console.Write(", ");
        }
    }
}
int[] ArrayResult = RandomArr();
PrintArr(ArrayResult);