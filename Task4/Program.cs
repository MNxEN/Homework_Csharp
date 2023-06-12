// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string strVal = Console.ReadLine();
int number = Convert.ToInt32(strVal);
int count = 1;
if (number < count)
{
    Console.WriteLine($"Число должно быть больше {count}!");
}
else
{
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        count++;
    }
}