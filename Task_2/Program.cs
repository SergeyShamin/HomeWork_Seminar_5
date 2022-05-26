/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях.
*/ 
void FillArray(int[] collection)
{
    Random randomeiser = new Random();

    for(int i = 0; i < collection.Length; i++)
    {    
        collection[i] = randomeiser.Next(-8, 9);
    }
}
void PrintArray (int [] array)
{
    foreach (int item in array)
    {
        Console.WriteLine($"{item}   ");
    }
}

int [] array = new int [8];
FillArray(array);
int summ = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0) 
    summ = summ + array[i];
}
Console.WriteLine("Полученный массив:");
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов {summ}");