// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Please enter coordinates for point A: ");
Console.Write ("X -  ");
int xa = int.Parse(Console.ReadLine());
Console.Write ("Y -  ");
int ya = int.Parse(Console.ReadLine());
Console.Write ("Z -  ");
int za = int.Parse(Console.ReadLine());

Console.WriteLine ();
Console.WriteLine ("Please enter coordinates for point B: ");
Console.Write ("X -  ");
int xb = int.Parse(Console.ReadLine());
Console.Write ("Y -  ");
int yb = int.Parse(Console.ReadLine());
Console.Write ("Z -  ");
int zb = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));

Console.WriteLine ($"Distance between two points {Math.Round(result, 2)}");