/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21 */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine ("Произведение пар чисел в одномерном массиве (первый и последний, второй и предпоследний и т.д.)");

//Запрашиваем числа для массива
Console.Write ("Введите числа через пробел: ");

//Присваиваем строковой переменной введённые значения массива
string elements = Console.ReadLine();

//Создаём переменную для вызова функции получения массива из строки
int[] array = GetArrayFromString(elements);

//Вывод решения задачи
Console.WriteLine(String.Join(" ", ResultArray(array)));

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

//Создадим функцию произведения пар чисел для решения задачи
int[] ResultArray(int[] array)
{
    int size = (array.Length) / 2;
    if(array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
