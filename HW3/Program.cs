//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for (int i=0; i < size; i++)
   {
    array[i] = new Random().Next(minValue, maxValue +1);
   }
   return array;
}

void PrintArray(int[] array)
{
   for (int i=0; i < array.Length; i++)  
   {
    Console.Write(array[i]+ " ");
   }
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size, min, max));

