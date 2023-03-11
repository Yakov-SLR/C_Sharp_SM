/* 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Расчёт функции Аккермана с помощью рекурсии для чисел M и N.");
Console.WriteLine();

// Определим и инициализируем переменные
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

//Вывод результатов
PrintAccerman(M, N);

//******* Функции ********
//Функция печати
void PrintAccerman(int M, int N)
{
   Console.Write(AccermanRe(M, N));
}

//Функция суммы натуральных элементов от M до N
int AccermanRe(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return AccermanRe(M - 1, 1);
    }
    else
    {
        return (AccermanRe(M - 1, AccermanRe(M, N - 1)));
    }
}