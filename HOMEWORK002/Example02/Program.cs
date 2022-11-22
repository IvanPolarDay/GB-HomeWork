// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (number.Length > 2)
{
    Console.WriteLine("третья цифра: " + number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



// Не могу понять почему не работает цикл, который должен сократить число до трехзначного.

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());



if (number >= 1000)
{
    for (int i = 0; number < 100; i++)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}
if (number >= 100 && number <= 999)
{
    Console.WriteLine(number % 10);
}
if (number <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
*/