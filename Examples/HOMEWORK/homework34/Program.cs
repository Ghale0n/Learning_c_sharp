// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

// [345, 897, 568, 234] -> 2

int[] getArray(int size, int minValue, int maxValue) // функция задаёт массив со случайными числами 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int evenCount(int[] numArray) //функция проверяет массив на чётность чисел
{
    int count = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if ((numArray[i] %2) == 0)       
        {
            count += 1;
        }
        else
        {
            count+=0;
        }
        
    }
    return count;
    //Console.WriteLine($"Количество чётных чисел в массиве: {count}"); - подходит, если это void функция
}



Console.Clear();

int[] threeArray = getArray(10, 100, 999);
Console.WriteLine(String.Join(", ", threeArray));

int finalArray = evenCount(threeArray);
Console.WriteLine($"В заданном массиве из 10 чисел - {finalArray} четных");