/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите число: ");
string str = Console.ReadLine()!;
int i = str.Length;
for (int i2 = 0; i2 < i; i2++, i--)
    if (str[i2] == str[i - 1])
    {
        continue;
    }
    else
    {
        Console.Write("Нет");
        return;
    }
Console.Write("Да");
