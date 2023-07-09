// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (b<a)
{
    Console.Write($"Максимальным числом будет {a}");
}
else
{
   Console.Write($"Максимальным числом будет {b}"); 
}