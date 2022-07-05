// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива

Random rand = new Random();
int rows = 4; // rand.Next(2, 10);
int columns = 4; // rand.Next(2, 10);
int[,] matrix = new int[rows, columns];
int[] RowSort = new int[columns];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {rows} строк (-и) и {columns} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

Console.WriteLine("Отсортируем каждую строку по убыванию:");
// SortRowsMaxToMin(matrix);
// PrintArray(matrix);

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

void ReplaceValuesIntoArray (int[,] currentArray, int[] tempArray, int row)
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
        for (int j = 0; j < tempArray.Length; j++)
        {
            if (tempArray[i] > tempArray[maxIndex]) maxIndex = i;
        }
        int temp = tempArray[i];
        tempArray[i] = tempArray[maxIndex];
        tempArray[maxIndex] = temp;
    }
}
