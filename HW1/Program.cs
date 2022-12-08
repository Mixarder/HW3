/*
Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());

if((num < 100000) && (num >= 10000))
{
    int a = num % 10 ; int b = num / 10000;
    int c = (num % 100) / 10; int d = (num / 1000) % 10;

    if (a==b && c==d)
    {
        Console.WriteLine($" Палиндром {num}");
        return;
    } 
    else 
    {
        Console.WriteLine($" Не палиндром {num}");
        return;
    }
 
}
Console.WriteLine("Введено не верное число");
