/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(0,1,0) 41(0,1,1)
27(1,0,0) 90(1,0,1)
26(1,1,0) 55(1,1,1) */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Вывод элементов трёхмерного массива с индексами.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите количество строк 3Д массива: ");
int Rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 3Д массива: ");
int Counts = int.Parse(Console.ReadLine());

Console.Write("Введите количество 2Д массивов в 3Д массиве: ");
int Arrays = int.Parse(Console.ReadLine());

int CountNums = 89;

//******* Обращения к функциям *******
//int result = TestParameters(Rows, Counts, Arrays, CountNums);
TestParameters(Rows, Counts, Arrays, CountNums);
//if (result != 0) 
int[,,] Array3D = Create3DMassive(Rows, Counts, Arrays);
PrintArray(Array3D);

//******* Функции ********

//Функция проверки длины 3Д массива
void TestParameters (int Rows, int Counts, int Arrays, int CountNums)
{
    if (Rows * Counts * Arrays > CountNums)
    {
        Console.WriteLine("Уменьшите входные данные массива");
        return;
        //System.Environment.Exit();
        //break;
    }
}

//функция создания 3Д массива
int[,,] Create3DMassive(int Rows, int Counts, int Arrays)
{
//    if (result == 0) return;
    int[,,] array = new int[Rows, Counts, Arrays];
    int[] values = new int[CountNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}

// //Функция проверки параметров перед печатью
// void TestParametrsBeforePrint(int[,,] Array3D, int result)
// {
//     if (result == 0)
//     {
//         Console.WriteLine("Уменьшите входные параметры массива");
//     }
//     else
//     {
//     PrintArray(Array3D);
//     }
// }

//Функция вывода 3Д массива
void PrintArray(int[,,] Array3D)
{
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] - {Array3D[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}