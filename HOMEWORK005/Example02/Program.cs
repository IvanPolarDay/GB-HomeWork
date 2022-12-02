// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = FillArray(10);
Console.WriteLine(FindNegativeIndex(array));


int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int FindNegativeIndex(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        count = count + array[i];
            return count;
}