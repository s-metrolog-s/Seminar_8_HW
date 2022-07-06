using System.Diagnostics;

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива

Random rand = new Random();
Stopwatch measureTime = new Stopwatch();
int rows = 10; //rand.Next(10, 20);
int columns = 10; // rand.Next(10, 20);
int[,] matrix = new int[rows, columns];
int[] rowSort = new int[columns];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {rows} строк (-и) и {columns} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

Console.WriteLine("Отсортируем каждую строку по убыванию при помощи одномерного массива:");
measureTime.Start();

for (int i = 0; i < rows; i++)
{
    ReplaceValuesIntoMatrix(matrix, rowSort, i);
    SortRow(rowSort);
    ReplaceValuesIntoArray(matrix, rowSort, i);
}

PrintArray(matrix);
measureTime.Stop();
Console.WriteLine($"Время выполнения цикла равно: {measureTime.ElapsedMilliseconds} миллисекундам");

Console.WriteLine($"*************************************************");
Console.WriteLine("Отсортируем каждую строку по убыванию внутри одного цикла:");
measureTime.Start();

SortMatrixRow(matrix);
PrintArray(matrix);

measureTime.Stop();
Console.WriteLine($"Время выполнения цикла равно: {measureTime.ElapsedMilliseconds} миллисекундам");
Console.WriteLine($"*************************************************");

void FillArray (int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray (int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ReplaceValuesIntoMatrix (int[,] currentArray, int[] tempArray, int row)
{ 
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        tempArray[j] = currentArray[row, j];
    }
}

void SortRow (int[] tempArray)
{
    for (int i = 0; i < tempArray.Length - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < tempArray.Length; j++)
        {
            if (tempArray[j] > tempArray[maxIndex]) maxIndex = j;
        }
        int temp = tempArray[i];
        tempArray[i] = tempArray[maxIndex];
        tempArray[maxIndex] = temp;
    }
}

void ReplaceValuesIntoArray (int[,] currentArray, int[] tempArray, int row)
{ 
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        currentArray[row, j] = tempArray[j];
    }
}

void SortMatrixRow (int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1) - 1; j++)
        {
            int maxIndex = j;
            for (int k = j + 1; k < currentArray.GetLength(1); k++)
            {
                if (currentArray[i, k] > currentArray[i, maxIndex]) maxIndex = k;
            }
            int temp = currentArray[i, j];
            currentArray[i, j] = currentArray[i, maxIndex];
            currentArray[i, maxIndex] = temp; 
        }
    }
}