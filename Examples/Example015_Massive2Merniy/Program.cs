﻿// string[,] table = new string[2, 5];

// String.Empty константа - инициализирут string 
// table [0,0]  table [0,1]  table [0, 2]  table [0, 3], table [0,4]
// table [1,0]  table [1,1]  table [1,2]  table [1, 3], table [1,4]
// Console.Clear();

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1, 10); //полуинтервал [1, 10)
        }
    }
}

Console.Clear();
int[,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);