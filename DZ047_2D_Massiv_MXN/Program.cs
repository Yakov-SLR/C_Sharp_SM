/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Создание двумерного массива размера M * N вещественных чисел.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите количество строк массива (M): ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива (N): ");
int N = int.Parse(Console.ReadLine());

int min = -9;
int max = 9;

//Вызов функции создания массива
double[,] array = GetArray(M, N, min, max);

//Вывод результата
Console.WriteLine();
PrintArray(array);

//Благодарности
Console.WriteLine();
Console.WriteLine("Благодарим за использование программы!");

//******* Функции ********

//Функция создания массива
double[,] GetArray(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble()*(max - min) + min;
        }
    }
    return result;
}

//создадим функцию вывода массива
void PrintArray(double[,] inArray)
{
    for (int rows = 0; rows < inArray.GetLength(0); rows++) // matrix.GetLength(0) - длина строк
    {
     for (int columns = 0; columns < inArray.GetLength(1); columns++) // matrix.GetLength(1) - длина столбцов
     {
        Console.Write($"{inArray[rows, columns]:f2} ");
     }
     Console.WriteLine();
    }
}