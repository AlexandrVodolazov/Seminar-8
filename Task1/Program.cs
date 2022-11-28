//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim);
        }
    }
    return table;
}
int[,] ChangeFirstLastRows(int[,] baseArray)
{
    const int i = 0;
    int k = baseArray.GetLength(0) - 1;
    for (int j = 0; j < baseArray.GetLength(1); j++)
    {
        Swap(baseArray, i, j, k, j);
    
    }
    return baseArray;

}

void Swap(int[,] baseArray, int i1, int j1, int i2, int j2)
{
    // int temp = baseArray[i1,j1];
    // baseArray[i1,j1] = baseArray[i2, j2];
    // baseArray[i2, j2] = temp;
    (baseArray[i1,j1], baseArray[i2, j2])=(baseArray[i2,j2], baseArray[i1,j1]);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Runner()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowLim = Prompt("Enter lower limit for array element value");
    int upperLim = Prompt("Enter upper limit for array element value");
    int [,] baseArray = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(baseArray);
    Console.WriteLine();
    int [,] changedArray = ChangeFirstLastRows(baseArray);
    PrintArray(changedArray);
}
Runner();

