/* Задайте массив заполненный
случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Создаём массив из случайных положительных трёхзначных чисел");

//Запрашиваем количество элементов для массива
Console.Write("Введите количество элементов массива: ");

//Создаём переменную, обозначающую количество элементов массива
int size = int.Parse(Console.ReadLine());

//Инициализируем минимальное и максимальное число элемента массива
int MinValue = 100;
int MaxValue = 1000;

//Создаём переменную для вызова функции создания массива
int[] array = NewArray(MinValue, MaxValue, size);

//Создадим переменную для вывода результата
int result = FindElements(array);
//Выводим пустую строку
Console.WriteLine();

//Запрашиваем необходимость вывода массива на экран
Console.Write("Нужно вывести массив на экран? (1 - да, 2 - не нужно): ");
//Создаём переменную для отладки
int otladka = int.Parse(Console.ReadLine());

//Выводим пустую строку
Console.WriteLine();

//Добавляем отладку
if(otladka == 1)
{
//Выводим первичный массив (для отладки)
Console.WriteLine("Выводим массив:");
Console.WriteLine(String.Join(" ", array));
}
else
{
    Console.WriteLine();
}
//Выводим пустую строку
Console.WriteLine();

//Выводим результат
Console.WriteLine($"Количество чётных элементов в массиве равно: {result}");

//Выводим пустую строку
Console.WriteLine();

//Благодарности:
Console.WriteLine("Благодарим за использование программы!");

//Создаём функцию создания массива и заполнения его случайными данными
int[] NewArray(int MinValue, int MaxValue, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return array;
}

//Создадим функцию подсчёта количества чётных чисел в массиве
int FindElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}