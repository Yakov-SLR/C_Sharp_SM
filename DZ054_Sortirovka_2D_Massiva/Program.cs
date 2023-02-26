/*Задайте двумерный массив. Напишите программу, которая 
упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Сортировка по строкам двумерного массива.");
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

//Зададим переменную для вывода сортировки массива
//int[,] result = ChangeArray(array);

//Вывод результатов
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сортировка по возрастанию:");
ChangeArray(array);
PrintArray(array);  

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
void ChangeArray(int[,] inArray)
{
//    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    
    //скопируем текущий массив в result
//    for (int a = 0; a < inArray.GetLength(0); a++)
//    {
    //     for (int b = 0; b < inArray.GetLength(1); b++)
    //     {
    //         result[a, b] = inArray[a, b];
    //     }
    // }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
            if (inArray[i, k] >= inArray[i, k + 1])
              {
                int temp = 0;
                temp = inArray[i, k];
                inArray[i, k] = inArray[i, k + 1];
                inArray[i, k+ 1] = temp; 
              }
            }
        }
    }
//    return result;
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