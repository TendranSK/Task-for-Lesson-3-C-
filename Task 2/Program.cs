/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84       AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double d = 0;
Console.WriteLine("Введите координаты двух точек.\n\n");
Console.WriteLine("Введите A(x):");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите A(y):");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите A(z):");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B(x):");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B(y):");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B(z):");
double z2 = Convert.ToDouble(Console.ReadLine());
d = Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2);


Console.WriteLine(Math.Round(d,2));
Console.WriteLine(Math.Round(Math.Pow(d,0.5),2));