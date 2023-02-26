/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Поиск строки с наименьшей суммой элементов в двумерном массиве.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите количество строк массива (M): ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива (N): ");
int N = int.Parse(Console.ReadLine());

int min = 0;
int max = 9;

//Вызов функции создания массива
int[,] array = GetArray(M, N, min, max);

//Зададим переменную для вывода результата
int result = FindRows(array);

//Вывод результатов
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке № {result}");
Console.WriteLine($"Примечание: начальное значение строки считается от 1");

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

//Создадим функцию сортировки массива
int FindRows(int[,] inArray)
{
    int count = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
//        int minsum = Int32.MaxValue;
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
          sum = sum + inArray[i, j];
        }
        if (sum < minsum)
              {
                minsum = sum;
                count++; 
              }
    }
    return count;
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