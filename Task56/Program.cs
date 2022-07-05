// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rand = new Random();
int rows = 7;
int coulumns = 7;
int[,] matrix = new int[rows, coulumns];
int[] matrixSumRows = new int[rows];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {rows} строк (-и) и {coulumns} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");
Console.WriteLine("Посчитаем сумму элементов каждой строки");

SumRows(matrix, matrixSumRows);
Console.WriteLine($"*************************************************");
MinRowFind(matrixSumRows);

Console.WriteLine($"*************************************************");

void FillArray (int [,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(0, 10);
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

void SumRows (int[,] currentArray, int[] arraySumRows)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            sum += currentArray[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна: {sum}");
        arraySumRows[i] = sum;
    }
}

void MinRowFind (int[] currentArray)
{
    int minSum = currentArray[0];
    int minRow = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] < minSum) 
        {
            minSum = currentArray[i];
            minRow = i;
        }
    }
    Console.WriteLine($"Минимальная сумма {minSum} в строке {minRow + 1}");
}