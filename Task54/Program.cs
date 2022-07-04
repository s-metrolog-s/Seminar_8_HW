// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива

Random rand = new Random();
int rows = 4; // rand.Next(2, 10);
int coulumns = 4; // rand.Next(2, 10);
int[,] matrix = new int[rows, coulumns];
int[,] matrixSort = new int[rows, coulumns];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {rows} строк (-и) и {coulumns} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

Console.WriteLine("Отсортируем каждую строку по убыванию:");
SortRowsMaxToMin(matrix);
PrintArray(matrix);

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

void SortRowsMaxToMin (int[,] currentArray)
{ 
    int maxValueIndexColumn = 0;
    int maxValueIndexRow = 0;
    int maxValue = currentArray[0, 0];
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        maxValueIndexRow = i;
        maxValue = currentArray[i, 0];
        for (int j = 0; j < currentArray.GetLength(1) - 1; j++)
        {
            maxValueIndexColumn = j;
            for (int k = j + 1; k < currentArray.GetLength(0); k++)
            {
                if (currentArray[i, k] > maxValue)
                {
                    maxValueIndexColumn = k;
                }
                int temp = currentArray[i, k];
                currentArray[i, k] = currentArray[maxValueIndexRow, maxValueIndexColumn];
                currentArray[maxValueIndexRow, maxValueIndexColumn] = temp;
            }
        }
    }
}