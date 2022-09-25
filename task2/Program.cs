/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координаты Х1");
int userCoordinateX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1");
int userCoordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z1");
int userCoordinateZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Х2");
int userCoordinateX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2");
int userCoordinateY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z2");
int userCoordinateZ2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(userCoordinateX2-userCoordinateX1, 2) + Math.Pow(userCoordinateY2-userCoordinateY1, 2) + Math.Pow(userCoordinateZ2-userCoordinateZ1, 2));
Console.WriteLine($"Ответ: {result}");