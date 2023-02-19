/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double[] A = new double[3];
double[] B = new double[3];
Console.Write("Введите А: ");
double.TryParse(Console.ReadLine()!, out A[0]);
double.TryParse(Console.ReadLine()!, out A[1]);
double.TryParse(Console.ReadLine()!, out A[2]);
Console.Write("Введите B: ");
double.TryParse(Console.ReadLine()!, out B[0]);
double.TryParse(Console.ReadLine()!, out B[1]);
double.TryParse(Console.ReadLine()!, out B[2]);
double ans = Math.Round(Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2)), 2);
Console.Write($"{A}; {B}, -> {ans}");