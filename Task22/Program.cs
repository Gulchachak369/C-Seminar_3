﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sqare = 1;
while (Sqare <= num) 
{
    System.Console.WriteLine(Sqare * Sqare);
    Sqare++;
}