// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Проверка числа на палиндром");
Console.WriteLine("Введите пятизначное число: ");
int chislo = int.Parse(Console.ReadLine());
if(chislo < 0)
{
    //otr = chislo;
    chislo = chislo * -1;
}
if(chislo <= 9999 || chislo > 99999) 
{
    Console.WriteLine("Введите корректное пятизначное число");
    return;
}
else
{
    Console.WriteLine("Число корректно, продолжаем.");
} 
string str = chislo.ToString();
if(str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine($"Число {chislo} является палиндромом.");
    Console.WriteLine("Благодарим за использование программы!");
}
else
{
    Console.WriteLine($"Число {chislo} не является палиндромом.");
    Console.WriteLine("Благодарим за использование программы");
}