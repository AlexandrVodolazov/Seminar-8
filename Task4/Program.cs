// // Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] array = CreateRandomArrayOfInt(5, 3, 1, 6);

PrintArrayOfInt(array);
int minI = 0;
int minJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[minI, minJ] > array[i, j])
        {
            minI = i;
            minJ = j;
        }
    }
}

int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minI != i && minJ != j)
        {
            int k = i;
            int l = j;
            if (k > minI) k--;
            if (l > minJ) l--;
            newArray[k, l] = array[i, j];
        }
    }
}

System.Console.WriteLine();
PrintArrayOfInt (newArray);





// Докрутила до упаковки в методы:

// // Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// // строку и столбец, на пересечении которых расположен наименьший элемент массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим 
// // следующий массив:
// // 9 4 2
// // 2 2 6
// // 3 4 7

// int Prompt(string msg)
// {
//     Console.WriteLine(msg);
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     return userInput;
// }

// int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
// {
//     int[,] table = new int[rows, columns];
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().Next(lowerLim, upperLim);
//         }
//     }
//     return table;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// (int minI, int minJ) FindMinElement(int[,] array)
// {
//     int minI = 0, minJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minI, minJ])
//             {
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     var minIndex = (minI, minJ);
//     return minIndex;
// }

// int[,] ReducedArray(int[,] baseArray, (int minI, int minJ) minIndex)
// {
//     int minI = minIndex.minI;
//     int minJ = minIndex.minJ;
//     int[,] reducedArray = new int[baseArray.GetLength(0) - 1, baseArray.GetLength(1) - 1];
//     for (int i = 0; i < baseArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < baseArray.GetLength(1); j++)
//         {
//             if ((i != minI) && (j != minJ))
//             {
//                 int k = i;
//                 int l = j;
//                 if (k > minI) k--;
//                 if (l > minJ) l--;
//                 reducedArray[k, l] = baseArray[i, j];
//             }
//         }
//     }
//     return reducedArray;
// }

// void Runner()
// {
//     int rows = Prompt("Enter quantity of raws ");
//     int columns = Prompt("Enter quantity of columns ");
//     int lowLim = Prompt("Enter lower limit for array element value");
//     int upperLim = Prompt("Enter upper limit for array element value");
//     int[,] baseArray = CreateArray(rows, columns, lowLim, upperLim);
//     PrintArray(baseArray);
//     Console.WriteLine();
//     int[,] reducedArray = ReducedArray(baseArray, FindMinElement(baseArray));
//     PrintArray(reducedArray);

// }
// Runner();