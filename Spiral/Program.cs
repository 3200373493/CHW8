// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] Spiral = SpiralArray(4, 4, 10);
PrintArray(Spiral);
Console.WriteLine();

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] SpiralArray(int rows, int columns, int First)
{
    int[,] Spiral = new int[rows, columns];
    int End = First;
    int count = 1;
    int minRow = 0;
    int maxRow = Spiral.GetLength(0) - 1;
    int minColumn = 0;
    int maxColumn = Spiral.GetLength(1) - 1;

    while (count <= Spiral.Length)
    {
        for (int i = minColumn; i <= maxColumn; i++)
        {
            Spiral[minRow, i] = End++;
            count++;
        }
        minRow++;

        for (int i = minRow; i <= maxRow; i++)
        {
            Spiral[i, maxColumn] = End++;
            count++;
        }
        maxColumn--;
        
        for (int i = maxColumn; i >= minColumn; i--)
        {
            Spiral[maxRow, i] = End++;
            count++;
        }
        maxRow--;
     
        for (int i = maxRow; i >= minRow; i--)
        {
            Spiral[i, minColumn] = End++;
            count++;
        }
        minColumn++;
    }
    return Spiral;
}