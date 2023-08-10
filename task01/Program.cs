﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



string Getresult(int n) 
    {
        if (n > 0) 
        return n + " " + Getresult(n-1);
        else
        {
            return "";
        }
    }
Console.WriteLine($" N = 5 -> {Getresult(5)}");
Console.WriteLine($" N = 8 -> {Getresult(8)}");