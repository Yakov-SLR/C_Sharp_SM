/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Заполнение спиралью массива 4 на 4.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите размеры массива: ");
int size = int.Parse(Console.ReadLine());

//******* Обращения к функциям *******
int[,] result = GetArray(size);
PrintArray(result);



//******* Функции ********
//Функция создания массива
int[,] GetArray(int size)
{
    int[,] Array = new int[size, size];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= size * size)
    {
        Array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
        j++;
        else if (i < j && i + j >= size - 1)
        i++;
        else if (i >= j && i + j > size - 1)
        j--;
        else i--;
        num ++;
    }
    return Array;
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