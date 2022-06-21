// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = Input("Введите размер массива: ");
int [] array = new int [size];
int amountEvenNumbers = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        amountEvenNumbers++;
    }
    
}
Console.WriteLine($"Количество четных чисел в заданном массиве: {amountEvenNumbers}");

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void FillArrayRandomNumbers(int [] array)
{
   for(int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(99, 1000);
   } 
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
