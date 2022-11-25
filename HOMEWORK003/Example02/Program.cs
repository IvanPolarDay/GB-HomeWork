// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите коорддинату X первой точки в трехмерном пространстве");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорддинату Y первой точки в трехмерном пространстве");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорддинату Z первой точки в трехмерном пространстве");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорддинату X второй точки в трехмерном пространстве");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорддинату Y второй точки в трехмерном пространстве");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорддинату Z второй точки в трехмерном пространстве");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($" A {x1},{y1},{z1}; B {x2},{y2},{z2}  -> {distance})");