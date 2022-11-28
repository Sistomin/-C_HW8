// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: "); // выхов метода ввода чисел
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): "); // выхов метода ввода чисел
int p = InputNumbers("Введите число столбцов 2-й матрицы: "); // выхов метода ввода чисел
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до "); // выхов метода ввода чисел

int[,] firstMartrix = new int[m, n]; // объявление первой матрицы
CreateArray(firstMartrix); // создание первой матрицы
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix); // ввывод в консоль первой матрицы

int[,] secomdMartrix = new int[n, p]; // объявление второй матрицы
CreateArray(secomdMartrix); // создание второй матрицы
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix); // ввывод в консоль второй матрицы

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix); // вызов метода расчета произведения двух матриц
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);// ввывод в консоль произведения двух матриц

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix) // метод для расчета произведения двух матриц
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input) // метод ввода чисел пользователем с консоли
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array) // метод создания матрицы/массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array) //метод вывода в консоль матрицы/массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}