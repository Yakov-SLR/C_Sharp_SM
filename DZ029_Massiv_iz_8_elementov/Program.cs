// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// На вход принимаем минимальное и максимальное значение в массиве
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Создаём массив из 8 элементов.");
Console.WriteLine();
Console.Write("Введите минимальное значение элемента массива: ");
int Min = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите максимальное значение элемента массива: ");
int Max = int.Parse(Console.ReadLine());
int size = 8;
//Обращаемся к функции создания массива:
int[] Array = NewArray(Min, Max, size);
Console.WriteLine();
Console.WriteLine("Выводим массив:");
Console.WriteLine(String.Join(" ", Array));

int[] NewArray(int Min, int Max, int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(Min, Max + 1);
    }
    return result;
}