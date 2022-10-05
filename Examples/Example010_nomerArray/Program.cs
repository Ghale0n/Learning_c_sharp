int[] array = { 1, 28, 33, 24, 55, 64, 37, 28 };

int n = array.Length;
int find = 33;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}