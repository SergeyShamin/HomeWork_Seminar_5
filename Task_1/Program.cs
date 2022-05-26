/* Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.
*/ 
void FillArray(int[] collection)
{
    Random randomeiser = new Random();

    for(int i = 0; i < collection.Length; i++)
    {    
        collection[i] = randomeiser.Next(100, 1000);
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
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }

}
Console.WriteLine("Полученный массив:");
PrintArray(array);
Console.WriteLine(count);

