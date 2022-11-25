// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


//Это было очень не просто. 


Console.WriteLine("Введите пятизначное число");

int inputNumber = Convert.ToInt32(Console.ReadLine());


int ConvertNumber(int inputNumber)
{
    int convertedNumber = 0;

    while (inputNumber > 0)
    {
        convertedNumber = (convertedNumber * 10 + (inputNumber % 10));
        inputNumber = inputNumber / 10;
    }

    return convertedNumber;
}


if (inputNumber == ConvertNumber(inputNumber))
{
    Console.WriteLine($"{inputNumber} -> да");
}
else
{
    Console.WriteLine($"{ConvertNumber(inputNumber)} -> нет");
}





