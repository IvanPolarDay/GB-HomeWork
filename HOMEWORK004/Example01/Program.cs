// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numA = 3;
int numB = 5;

Console.WriteLine(GetExponentation(numA, numB));

int GetExponentation(int numberA, int numberB)
{
    int i = 1;
    int temp = numA;
    while (i < numberB)
    {
        numberA = numberA * temp;
        i++;
    }
    return numberA;
}