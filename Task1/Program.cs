// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
string str1 = Console.ReadLine();
int number1 = Convert.ToInt32(str1);
Console.Write("Введите второе число: ");
string str2 = Console.ReadLine();
int number2 = Convert.ToInt32(str2);
if (number1 > number2)
{
    Console.Write($"max = {number1}, min = {number2}");
}
else
{
    Console.Write($"max = {number2}, min = {number1}");
}