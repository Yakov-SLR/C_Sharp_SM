// Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

//Очищаем консоль
Console.Clear();
//Выводим название программы
Console.WriteLine("Создаём одномерный массив из 123 элементов от 0 до 1000.");

//Выводим пустую строку
Console.WriteLine();

//Запрашиваем необходимость вывода массива на экран
Console.Write("Нужно вывести массив на экран? (1 - да, 2 - не нужно): ");

int otladka = int.Parse(Console.ReadLine());

//Заводим переменную для одномерного массива и присваиваем ей функцию по созданию этого массива
int[] baseArray = NewArray(1, 1000, 123);

//Заводим переменную Result и присваиваем ей функцию поиска элементов для решения задачи
int Result = FindElement(baseArray); 

if(otladka == 1)
{
//Выводим первичный массив (для отладки)
Console.WriteLine("Выводим массив:");
Console.WriteLine(String.Join(" ", baseArray));
}
else
{
    Console.WriteLine();
}


//Выводим пустую строку
Console.WriteLine();

//Выводим искомый результат
Console.WriteLine($"Количество цифр от 10 до 99 = {Result}");

//Выводим пустую строку
Console.WriteLine();

//Благодарности:
Console.WriteLine("Благодарим за использование программы!");

//Создаём функцию создания массива и заполнения его случайными данными
int[] NewArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//Создаём функцию поиска элементов для решения задачи
int FindElement(int[] array)
{
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100) result = result + 1;
}
    return result;
}