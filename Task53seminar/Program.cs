// задача 53 Задайте двухмерный массив. Напишите программу которая поменяет первую и последнию строку массива

Console.Write("Введите колличество сторок массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($" ");
ChengArr(array);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChengArr(int[,] inArray)
{
    int temp = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;
    }
}