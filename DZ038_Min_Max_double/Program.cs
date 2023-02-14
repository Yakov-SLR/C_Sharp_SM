/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Создаём массив из случайных вещественных чисел и ищем разницу между минимальным и максимальнм значением элементов.");

//Запрашиваем количество элементов для массива
Console.Write("Введите количество элементов массива: ");

//Создаём переменную, обозначающую количество элементов массива
int size = int.Parse(Console.ReadLine());

//Инициализируем минимальное и максимальный диапазон элементов массива
//Console.Write("Введите минимально возможное значение элемента массива: ");
Double MinValue = 1;
//Console.Write("Введите максимально возможное значение элемента массива: ");
Double MaxValue = 99;

//Создаём переменную для вызова функции создания массива
Double[] array = NewArray(MinValue, MaxValue, size);

//Создадим переменные для вывода результата
Double resultMin = FindMin(array);
Double resultMax = FindMax(array);
Double result = resultMax - resultMin;
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
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов равна: {result:f2}");

//Выводим пустую строку
Console.WriteLine();

//Благодарности:
Console.WriteLine("Благодарим за использование программы!");

//Создаём функцию создания массива и заполнения его случайными данными
Double[] NewArray(Double MinValue, Double MaxValue, int size)
{
    Double[] array = new Double[size];
    for (int i = 0; i < size; i++)
    {
       // array[i] = new Random().NextDouble(MinValue, MaxValue + 1);
       array[i] = new Random().NextDouble() * (MinValue + MaxValue);
    }
    return array;
}

//Создадим функцию подсчёта минимального элемента в массиве
Double FindMin(Double[] array)
{
    Double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] <= min) min = array[i];
    }
    return min;
}
//Создадим функцию подсчёта максимального элемента в массиве
Double FindMax(Double[] array)
{
    Double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= max) max = array[i];
    }
    return max;
}

