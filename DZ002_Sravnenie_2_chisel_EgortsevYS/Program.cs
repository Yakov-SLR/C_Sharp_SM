// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Сравнение двух чисел");
Console.Write("Введите число № 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число № 2: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 < number2) {
    Console.WriteLine($"Число № 2 больше и составляет: {number2}");
    Console.WriteLine($"Число № 1 меньше и составляет: {number1}");
    return;
}
if (number2 < number1) {
    Console.WriteLine($"Число № 1 больше и составляет: {number1} ");
    Console.WriteLine($"Число № 2 меньше и составляет: {number2} ");
    return;
}
if(number1 == number2) {
    Console.WriteLine($"Числа № 1 и № 2 равны и составляют: {number1} и {number2}");
    return;
}