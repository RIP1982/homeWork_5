// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = Input("Enter the length of the array: ");
int [] array = new int[size];
int maxValue = array[0];
int minValue = array[0];
int diff;


FillArrayRandomNumber(array);
PrintArray(array);


int Input(String output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandomNumber(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(- 1000, 1000); 
    }
}


void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

for(int i = 0; i < array.Length; i++)
{
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
    else if (minValue > array[i])
    {  
         minValue = array[i];
    }

}
 
    diff = maxValue - minValue;

 Console.WriteLine($"Differece in substraction: {maxValue} - {minValue} = {diff}");

