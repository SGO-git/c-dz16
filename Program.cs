// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int size, double leftRange, double rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 2);
    }

    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double MinMax(double[] array)
{
    double min = array[0];
    double max = array[1];
    double res = 0;
    if (max < min)
    {
        min = array[1];
        max = array[0];
    }
    else
    {
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
    System.Console.WriteLine($"max = {max}");
    System.Console.WriteLine($"min = {min}");
    res = Math.Round(max - min, 2);
    return res;
}

double[] myArray = GenerateArray(5, 0, 100);
PrintArray(myArray);
System.Console.WriteLine($"res = {MinMax(myArray)}");