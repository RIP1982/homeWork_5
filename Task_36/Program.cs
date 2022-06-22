// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = Input("Enter the length of the array: ");
int[] array = new int[size];
int sum = 0;


FillArrayRandomNumber(array);
PrintArray(array);


for(int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}

Console.WriteLine($"Sum of odd array elements = {sum}");


int Input(String output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandomNumber(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000); 
    }
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}



