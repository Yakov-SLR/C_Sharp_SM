/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Поиск среднего арифметического в двумерном массиве.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите количество строк в массиве: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество колонок в массиве: ");
int N = int.Parse(Console.ReadLine());

int min = 1;
int max = 9;

//Вызов функции создания массива
int[,] array = GetArray(M, N, min, max);

//Вызов функции поиска элемента
//int Result = FindElements(array, M, N);

//Вывод результата
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindArif(array);

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
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

//Создадим функцию поиска элемента массива
void FindArif(int[,] inArray)
{
    //int el = 0;
    double sum = 0;
    double arif = 0;
    double count = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
            count++;
        }
        arif = sum / count;
        Console.WriteLine($"Среднее арифметическое столбца {j}: {arif:f2}");
        sum = 0;
        count = 0;
    }    
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