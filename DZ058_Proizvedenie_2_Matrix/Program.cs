/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Вычисление произведения двух матриц.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите количество строк матриц (M): ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матриц (N): ");
int N = int.Parse(Console.ReadLine());

int min = 0;
int max = 9;

//Инициализируем переменные и вызовем функцию создания массива
int[,] array1 = GetArray(M, N, min, max);
int[,] array2 = GetArray(M, N, min, max);

//Зададим переменную для вывода результата
int[,] result = Multi(array1, array2);

//Вывод результатов
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение элементов 2 матриц равно:");
Console.WriteLine();
PrintArray(result);


//Благодарности
Console.WriteLine();
Console.WriteLine("Благодарим за использование программы!");

//******* Функции ********

//Функция создания массива
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

//Создадим функцию умножения массивов
int[,] Multi(int[,] inArray1, int[,] inArray2)
{
    //int count = 0;
    int[,] result = new int[inArray1.GetLength(0),inArray1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
//        int multu = 0; 
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i, j] = inArray1[i, j] * inArray2[i, j];
        }
    }
    return result;
}

//создадим функцию вывода массива
void PrintArray(int[,] inArray)
{
    for (int rows = 0; rows < inArray.GetLength(0); rows++) // matrix.GetLength(0) - длина строк
    {
     for (int columns = 0; columns < inArray.GetLength(1); columns++) // matrix.GetLength(1) - длина столбцов
     {
        Console.Write($"{inArray[rows, columns]} ");
     }
     Console.WriteLine();
    }
}