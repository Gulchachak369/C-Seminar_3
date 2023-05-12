// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1)
{
    Console.Write("x > 0 Y > 0");
} 
if (quater == 2)
{
    Console.Write("x < 0 Y > 0");
} 
if (quater == 3)
{
    Console.Write("x < 0 Y < 0");
} 
if (quater == 4)
{
    Console.Write("x > 0 Y < 0");
} 