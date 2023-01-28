// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.WriteLine("Вывод чётных чисел до числа N");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int chetnoe = 1;
Console.WriteLine("Выводим чётные числа: ");
while (chetnoe < N) 
{
if(chetnoe % 2 == 0)
 {
Console.Write(" ");
Console.Write(chetnoe);
 }
 chetnoe = chetnoe + 1;
}