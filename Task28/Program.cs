﻿// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductOfNumbers(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i;
    }
    return product;
}

int N = Convert.ToInt32(Console.ReadLine());
int prod = ProductOfNumbers(N);

Console.WriteLine($"Произведение чисел от 1 до {N} = {prod}");