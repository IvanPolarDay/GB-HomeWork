// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = FillArray(10);

Console.WriteLine(FindMaxValue(array) - FindMinValue(array));

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

double FindMaxValue(double[] array)
{
    double maxValue = 0;
    for (int i = 0; i < array.Length; i++)
    if(maxValue < array[i])
    {
        maxValue = array[i];
    }
        return maxValue;
}

double FindMinValue(double[] array)
{
    double minValue = FindMaxValue(array);
    for (int i = 0; i < array.Length; i++)
    if(minValue > array[i])
    {
        minValue = array[i];
    }
        return minValue;
}