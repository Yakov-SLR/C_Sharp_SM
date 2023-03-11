/* 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Сумма натуральных элементов от M до N с помощью рекурсии.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

//Вывод результатов
PrintNumbers(M, N);

//******* Функции ********
//Функция печати натуральных чисел от M до N
void PrintNumbers(int M, int N)
{
   Console.Write(SumNumbersRe(M - 1, N));
}

//Функция суммы натуральных элементов от M до N
int SumNumbersRe(int M, int N)
{
    int result = M;
    if (M == N)
    {
        return 0;
    }
    else
    {
        M++;
        result = M + SumNumbersRe(M, N);
        return result;
    }
}