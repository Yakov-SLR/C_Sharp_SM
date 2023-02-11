// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Сумма цифр в числе.");
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int sum = SumNumbers(N);

// Вывод цифр в строку
Console.WriteLine($"Сумма цифр равна {sum}");

//Пишем функцию перевода числа в строку и вывода сложения цифр
int SumNumbers(int N) //Вводим аргумент нашего числа N
{
    int result = 0;
    while (N > 0)
    {
    result = result + N%10; //Добавляем в результат остаток от деления
    N /= 10; //Делим целое число на 10
    }
    return result;
}