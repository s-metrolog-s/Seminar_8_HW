// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];

Console.Clear();
Console.WriteLine("*************************************************");
Console.WriteLine($"Дан массив на {rows} и {columns} стролбцов");
Console.WriteLine("*************************************************");

Console.WriteLine("Заполняем массив по змейкой^");
FillArraySnake(matrix);
PrintArray(matrix);

Console.WriteLine("*************************************************");
FillArraySpiral(matrix);
PrintArray(matrix);

void FillArraySnake (int[,] currentArray)
{
    int count = 1;
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                currentArray[i, j] = count++;
            }
        }
        else
        {
            for (int j = currentArray.GetLength(1) - 1; j >= 0; j--)
            {
                currentArray[i, j] = count++;
            }
        }
    }
}

void FillArraySpiral (int[,] currentArray)
{
    
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