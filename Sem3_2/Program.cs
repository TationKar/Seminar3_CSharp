// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
Console.Clear();
Console.Write("Введите координату АХ: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату АY: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату BХ: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату BY: ");
int by = int.Parse(Console.ReadLine());

double s = Math.Sqrt((Math.Pow((ax - bx),2) + Math.Pow((ay - by),2)));
Console.WriteLine($"расстояние между точками {Math.Round(s, 3)}");