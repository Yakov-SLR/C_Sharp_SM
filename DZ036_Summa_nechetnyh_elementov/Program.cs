/* Задайте одномерный массив,
заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Создаём массив из случайных чисел и ищем сумму нечётных элементов.");

//Запрашиваем количество элементов для массива
Console.Write("Введите количество элементов массива: ");

//Создаём переменную, обозначающую количество элементов массива
int size = int.Parse(Console.ReadLine());

//Инициализируем минимальное и максимальное число элемента массива
Console.Write("Введите минимальное значение элемента массива: ");
int MinValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int MaxValue = int.Parse(Console.ReadLine());

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
Console.WriteLine($"Сумма чётных элементов в массиве равна: {result}");

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

//Создадим функцию подсчёта суммы чётных чисел в массиве
int FindElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count = count + array[i];
    }
    return count;
}