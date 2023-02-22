/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Поиск элемента двумерного массива.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.WriteLine("Для поиска элемента введите номер строки (от 0 до 9): ");
int Row = int.Parse(Console.ReadLine());

Console.WriteLine("Для поиска элемента введите номер столбца (от 0 до 9): ");
int Column = int.Parse(Console.ReadLine());

Console.WriteLine("Количество строк массива задано случайно.");
int M = new Random().Next(1, 9);

Console.WriteLine("Количество столбцов массива задано случайно.");
int N = new Random().Next(1, 9);

int min = 0;
int max = 99;

//Вызов функции создания массива
int[,] array = GetArray(M, N, min, max);

//Вызов функции поиска элемента
int Result = FindElements(array, Row, Column, M, N);

//Вывод результата
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintResult(Result);

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
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

//Создадим функцию поиска элемента массива
int FindElements(int[,] inArray, int Row, int Column, int M, int N)
{
    int result = 0;
    if (Row > M && Column > N)
    {
       result = -99; 
    }
    else
    {
        result = inArray[Row, Column];
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

//Функция вывода результата
void PrintResult(int Result)
{
    if (Result == -99)
    {
        Console.WriteLine ("Такого значения в массиве нет, введите другое значение!");
    }
    else
    {
    Console.WriteLine($"Значение искомого элемента найдено и равно: {Result}");
    }
}