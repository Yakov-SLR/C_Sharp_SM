/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

//Очищаем консоль
Console.Clear();

//Выводим название программы
Console.WriteLine("Поиск точки пересечения 2-х прямых, согласно уравнениям: y = k1 * x + b1, y = k2 * x + b2 ");

//Введём координаты b1
Console.Write("Введите координаты b1: ");
double b1 = int.Parse(Console.ReadLine());

//Введём координаты k1
Console.Write("Введите координаты k1: ");
double k1 = int.Parse(Console.ReadLine());

//Введём координаты b2
Console.Write("Введите координаты b2: ");
double b2 = int.Parse(Console.ReadLine());

//Введём координаты k2
Console.Write("Введите координаты k2: ");
double k2 = int.Parse(Console.ReadLine());

//Вызываем метод расчёта X
double x = FindX(b1, b2, k1, k2);

//Вызываем метод расчёта Y
double y = FindY(b1, b2, k1, k2);

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double b1, double b2, double k1, double k2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}


Console.WriteLine($"Точка пересечения двух прямых X = {x:f2}, Y = {y:f2}");