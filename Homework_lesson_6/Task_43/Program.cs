//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Функция получения от пользователя коэфициэнтов уравнения
(double, double, double, double) GetCoef(string message)
{
    double b1, k1, b2, k2;
    Console.WriteLine(message);
    
    Console.Write($"Please enter coefficient b1: ");
    b1 = double.Parse(Console.ReadLine() ?? "");
    Console.Write($"Please enter coefficient k1: ");
    k1 = double.Parse(Console.ReadLine() ?? "");
    Console.Write($"Please enter coefficient b2: ");
    b2 = double.Parse(Console.ReadLine() ?? "");
    Console.Write($"Please enter coefficient k2: ");
    k2 = double.Parse(Console.ReadLine() ?? "");

    return (b1, k1, b2, k2);
}

//Функция расчета точки пересечения (используется кортеж первым возвращается Х вторым Y)
(double, double) GetIntersectionPoint (double b1, double k1, double b2, double k2)
{
    double x, y;
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    return (x, y);
}

(double b1, double k1, double b2, double k2) = GetCoef("Please enter coefficients for equation y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine($"Intersection point (x, y): {GetIntersectionPoint (b1, k1, b2, k2)}");