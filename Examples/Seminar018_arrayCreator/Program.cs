//  Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] getArray(int size, int minValue, int maxValue) // функция задаёт массив со случайными числами 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}




Console.Clear();
int[] array = getArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array)); // обращение к строке заданного "array" с использованием разделителя ", " - пробел

int positiveSumm = 0;
int negativeSumm = 0;

foreach (int el in array)
{
    positiveSumm += el > 0 ? el : 0; // тернарный оператор  (если оператор положительный, добавляем его к сумме, в противном случае добавляем 0)
    // if (el > 0)
    // {
    //     positiveSumm += el;
    // }
    // else
    // {
    //     positiveSumm += 0;
    // }

    negativeSumm += el <0 ? el :0; // то же самое , но с отрицательными числами
}

Console.WriteLine($"Сумма положительных элементов: {positiveSumm}, сумма отрицательных: {negativeSumm}");