// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[] { number1, number2 };

Console.WriteLine($"Маскимальное введенное число: {Array.Max()} Мнимальное число: {Array.Min()}");


// Альтернативное решение
/*
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int maxNum = number2;
int minNum = number1;

if (number1 > number2)
{
    maxNum = number1;
    minNum = number2;
}
Console.WriteLine($"Маскимальное введенное число: {maxNum} Мнимальное число: {minNum}");
*/
