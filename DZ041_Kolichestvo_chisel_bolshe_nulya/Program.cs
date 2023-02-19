/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Поиск чисел больше нуля.");

//Запрашиваем ввод чисел, и создаём строковую переменную
Console.Write("Введите целые числа через пробел: ");
string elements = Console.ReadLine();

//Создаём переменную для вызова функции получения массива из строки
int[] array = GetArrayFromString(elements);

//Создадим переменную для вызова функции поиска элементов
int result = FindElements(array);

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

//Выведем результат
Console.WriteLine($"Количество элементов в массиве больше нуля равно: {result}");

//Выводим пустую строку
Console.WriteLine();

//Благодарности:
Console.WriteLine("Благодарим за использование программы!");

//Создаём функцию заполнения массива из строки
int[] GetArrayFromString(string arraystr)
{
    string[] elements = arraystr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[elements.Length];
    for (int i = 0; i < elements.Length; i++)
    {
        result[i] = int.Parse(elements[i]);
    }
    return result;
}

//Создадим функцию поиска элементов больше нуля
int FindElements(int[] inArray)
{
    result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
    if(inArray[i] > 0) result++;
    }
    return result;
}
