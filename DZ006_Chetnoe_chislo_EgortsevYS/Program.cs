//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
Console.WriteLine("Проверка чётности числа");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0) {
    Console.WriteLine($"Введённое число {number} является чётным");
}
else {
    Console.WriteLine($"Введённое число {number} является нечётным");
}