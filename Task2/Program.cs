// Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateRandomArrayOfInt(int rows, int cols, int min, int max) // Создает двумерный массив с заданой размерностью и границами генерации целых чисел
{
    int[,] temp = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            temp[i, j] = new Random().Next(min, max + 1);
        }
    }
    return temp;
}

void PrintArrayOfInt(int[,] array) // Печать двумерного массива целых чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i, 0]}\t");
        for (int j = 1; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

bool TransposeArray(int[,] array) // заменяет строки на столбцы
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
        return true;
    }
    else return false;
}

void Main()
{
    System.Console.Clear();
    const int rowsInArray = 4;
    const int colsInArray = 4;
    const int minOfRandom = -5;
    const int maxOfRandom = 5;
    int[,] arrayOfInt = CreateRandomArrayOfInt(rowsInArray, colsInArray, minOfRandom, maxOfRandom);
    PrintArrayOfInt(arrayOfInt);
    System.Console.WriteLine();
    if (TransposeArray(arrayOfInt)) PrintArrayOfInt(arrayOfInt);
    else System.Console.WriteLine("Количество строк и столбцов разные");
}

Main();
