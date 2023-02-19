/* Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
int p;
for (int i = 1; i <= N; i++)
{
    p = i * i * i;
    Console.WriteLine($"{N} -> {p}");
}
