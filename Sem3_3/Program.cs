// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

if (num == 0 )
    Console.Write("0");

while (count <= num)
{
    Console.Write(Math.Pow(count, 2));
    Console.Write(" ");
    count++;
}
Console.WriteLine();