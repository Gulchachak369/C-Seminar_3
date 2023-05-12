// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 1000)
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}
else if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
{
    System.Console.WriteLine("Введенное число является палиндромом");
}
else
{
    System.Console.WriteLine("Введенное число не является палиндромом");
}