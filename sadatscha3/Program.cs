// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
if (b<a)
{
    Console.Write($"Максимальным числом будет {a}"); 
    a = max;
}
else
{
   Console.Write($"Максимальным числом будет {b}"); 
   b = max;
}
if (c>max)
{
    c = max;
    Console.Write($"Максимальным числом будет {c}"); 
}
