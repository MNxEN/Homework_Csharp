﻿// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
string strVal = Console.ReadLine();
int number = Convert.ToInt32(strVal);
if (number % 2 == 0) 
{
    Console.WriteLine($"Число: {number} - четное");
}
else
{
    Console.WriteLine($"Число: {number} - нечетное");
}
