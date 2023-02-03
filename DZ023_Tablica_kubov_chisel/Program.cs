// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Составляем таблицу кубов целых чисел до введённого числа");
Console.WriteLine("");
Console.WriteLine("Введите целое число: ");
int N = int.Parse(Console.ReadLine());
//int M = N;
if(N < 0) //Если N отрицательное, меняем его знак
{
    Console.WriteLine($"Введено отрицательное число {N}");
    N = N * -1;
    int[] array = new int[N];
    int i = 1;
    int j = 0;
        for (j = 0; i <= N; i++)   
     {
       array[j] = i * i * i;
       j++;
     }
    Console.Write($"-{N} -> ");
    for (j = 0; j < N; j++)
    {
    Console.Write($"-{array[j]}");
    Console.Write(", ");   
    }
}
else
{
int[] array = new int[N];
int i = 1;
int j = 0;
for (j = 0; i <= N; i++)   
{
    array[j] = i * i * i;
    //Console.WriteLine($"Служебная информация, цикл for1: {array[j]}");
    j++;
    //return;
}
Console.Write($"{N} -> ");
for (j = 0; j < N; j++)
{
    Console.Write($"{array[j]}");
    Console.Write(", ");
}
}
Console.WriteLine("");
Console.WriteLine("Благодарим за использование программы!");