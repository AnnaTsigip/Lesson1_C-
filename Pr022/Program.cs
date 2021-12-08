// Найти расстояние между точками в пространстве 2D/3D
// вводим х1,х2, у1,у2
// расстояние между точками =корень из (х2-х1)в квадрате + (у2-у1)в квадрате

// Console.WriteLine("Введите координаты точки X: ");
// double X1 = Convert.ToDouble(Console.ReadLine());
// double X2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Введите координаты точки Y: ");
// double Y1 = Convert.ToDouble(Console.ReadLine());
// double Y2 = Convert.ToDouble(Console.ReadLine());

// double X = Math.Pow((X2 - X1),2);
// double Y = Math.Pow((Y2 - Y1),2);
// double distanceXY = Math.Sqrt(X + Y);

// Console.WriteLine($"X равен {X}");
// Console.WriteLine($"Y равен {Y}");
// Console.WriteLine();
// Console.WriteLine($"Расстояние между точками Х и У равно {distanceXY}");

// double distanceMetoth(double X1, double X2, double Y1, double Y2, double Z1, double Z2)
// {
//     double X = Math.Pow((X2 - X1),2);
//     double Y = Math.Pow((Y2 - Y1),2);
//     double Y = Math.Pow((Y2 - Y1),2);
//     double distance = Math.Sqrt(X + Y);
//     return distanse;
// }

// Console.WriteLine($"Расстояние между точками Х и У и Z равно {distance}");

// Console.WriteLine("Введите координаты точки X: ");

Console.WriteLine("Введите координаты точки X: ");
double X1 = Convert.ToDouble(Console.ReadLine());
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты точки Y: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки Z: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
double Z2 = Convert.ToDouble(Console.ReadLine());

double X = Math.Pow((X2 - X1),2);
double Y = Math.Pow((Y2 - Y1),2);
double Z = Math.Pow((Z2 - Z1),2);
double distanceXYZ = Math.Sqrt(X + Y + Z);

Console.WriteLine($"X равен {X}");
Console.WriteLine($"Y равен {Y}");
Console.WriteLine($"Z равен {Z}");
Console.WriteLine();
Console.WriteLine($"Расстояние между точками Х и У и Z равно {distanceXYZ}");
