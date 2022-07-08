// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

int rows = 5;
int columns = 5;
int[,] matrix = new int[rows, columns];

Console.Clear();
Console.WriteLine("*************************************************");
Console.WriteLine($"Дан массив на {rows} и {columns} стролбцов");
Console.WriteLine("*************************************************");

Console.WriteLine("Заполняем массив змейкой");
FillArraySnake(matrix);
PrintArray(matrix);

Console.WriteLine("*************************************************");

Console.WriteLine("Заполняем массив по спирали");
//FillArraySpiral(matrix, rows, columns);
//PrintArray(matrix);

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

/*
void FillArraySpiral (int[,] currentArray, int rows, int columns)
{
    int count = 1;
    int circle = 1;
    int itteration = 0;
    while (count < currentArray.GetLength(0) * currentArray.GetLength(1))
    {
        int direction = 1;
        if (direction == 1)
        {
            for (int j = circle - 1; j < columns - circle + 1; j++)
            {
                currentArray[circle - 1, j] = count++;
            }
            direction = 2;
        }

        if (direction == 2)
        {
            for (int i = circle + 1; i < currentArray.GetLength(0) - circle; i++)
            {
                currentArray[i, currentArray.GetLength(1) - column + circle] = count;
                count++;
            }
            direction = 3;
            column++;
        }
  
        if (direction == 3)
        {
            for (int j = currentArray.GetLength(1) - row - 1; j >= circle; j--)
            {
                currentArray[currentArray.GetLength(0) - 1 - circle, j] = count;
                count++;
            }
            direction = 4;
            row++;
        }
        
        if (direction == 4)
        {
            for (int i = currentArray.GetLength(0) - column; i >= 1; i--)
            {
                currentArray[i, 0] = count;
                count++;
            }
            direction = 1;
            column++;
        }
        
        circle++;
        
        /*
        if (direction == 7)
        {
            for (int j = currentArray.GetLength(1) - row; j >= circle; j--)
            {
                currentArray[currentArray.GetLength(0) - 1 - circle, j] = count;
                count++;
            }
            direction = 1;
            row++;
        }
        
        break;
    }
}
*/

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