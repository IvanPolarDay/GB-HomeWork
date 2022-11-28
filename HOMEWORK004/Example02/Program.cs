// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int inputNumber = 452;
Console.WriteLine(Summ(inputNumber));

int Summ(int number)
{
    int temp = 0;
    int sumNumber = 0;
    while (number > 0)
    {
        temp = number % 10;
        sumNumber = sumNumber + temp;
        number = number / 10;
    }
    return sumNumber;
}