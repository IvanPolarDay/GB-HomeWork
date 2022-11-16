// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());


int[] array = new int[] { number1, number2, number3 };

int maxNum = array[0];

for (int index = 0; index < array.Length; index++)
    if (maxNum < array[index])
    {
        maxNum = array[index];
    }

Console.WriteLine($"Маскимальное введенное число: {maxNum}");

// Альтернативное решение
/*
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[] { number1, number2, number3 };

Console.WriteLine($"Маскимальное введенное число: {Array.Max()}");
*/