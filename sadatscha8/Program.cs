﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
for(int i=2; i<n;)
{
    if (i%2==0);
      {        
      Console.Write($"{i}");
      i++;
    }
    i++;
  }
  Console.WriteLine($"{n}");