// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = FillArray(10);
Console.WriteLine(CountPositiveNumbers(array));


int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}
