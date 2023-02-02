// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Отображение третьей цифры заданного числа");
Console.WriteLine("Введите целое число: ");
int num = Int32.Parse(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Введите корректное число (трёхзначное и более)!");
}
else
{
    
    string str = num.ToString();
    string num3 = Convert.ToString(str[2]);
    Console.WriteLine($"Третья цифра равна: {num3}");
}