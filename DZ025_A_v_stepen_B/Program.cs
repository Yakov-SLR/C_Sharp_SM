// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Возводим число A в натуральную степень B.");
Console.WriteLine("Введите целое число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число B: ");
int B = int.Parse(Console.ReadLine());
int result = A;

// Вводим новую функию возведения в степень
int StepenChisel(int A, int B, int result) // Указываем типы и имена аргументов
{
    int i = 1;
    for (i = 1; i < B; i++)
    {
        result = result * A;
    }
    
    return result;
}

// Используем функцию возведения в степень и передаём ей требуемые аргументы
int res = StepenChisel(A, B, result);
Console.WriteLine($"Число A = {A}; Число B = {B}; Результат = {res} ");