// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Сравнение трёх чисел");
Console.Write("Введите число № 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число № 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число № 3: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if(number2 > max) {
    max = number2;
//    return;
}
if (number3 > max) {
    max = number3;
//    return;
}
Console.WriteLine($"Максимальное число найдено и равно {max}");