/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/ 

double[] ReadArray()
{
    double[] array = new double[10];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");

        array[i] = double.Parse(Console.ReadLine());
    }

    return array;
}

double GetMin (double [] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            {
                min = array[i];
            }
    }

    return min;
}
double GetMax (double [] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
    }

    return max;
}

double[] array = ReadArray();
double min = GetMin(array);

double max = GetMax(array);
double result = max - min;

Console.WriteLine($"Разница между {max} и {min} равна {result}");