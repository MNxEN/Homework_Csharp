// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
string str1 = Console.ReadLine();
int number1 = Convert.ToInt32(str1);
Console.Write("Введите второе число: ");
string str2 = Console.ReadLine();
int number2 = Convert.ToInt32(str2);
Console.Write("Введите третье число: ");
string str3 = Console.ReadLine();
int number3 = Convert.ToInt32(str3);
if (number1 > number2 & number1 > number3)
{
    Console.Write($"max = {number1}");
}
else if (number2 > number1 & number2 > number3)
{
    Console.Write($"max = {number2}");
}
else
{
    Console.Write($"max = {number3}");
}