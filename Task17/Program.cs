// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координту X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координту Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.Write("Точка лежит в первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.Write("Точка лежит во второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.Write("Точка лежит в третьей четверти");
}
else 
{
    Console.Write("Точка лежит в четвертой четверти");
}