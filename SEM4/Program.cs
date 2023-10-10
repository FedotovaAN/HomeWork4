//  программу, которая принимает на вход число и выдает колво цифр в числе

//int DigitCount(int num)
//{
    //int count = 0;
    //for (int i = 1; Math.Abs(num) >0; i++)
    //{
       //num /= 10;
       //count = i;
    //}
    //return count;
//}
//Console.Write("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write(DigitCount(num));

//Найти сумму чисел от 1 до N, написать программу
//int FindSum(int n)
//{
    //int sum = 0;
    //for (int i=0; i<= n; i++) 
    //{
        //sum+=i;
    //} 
    //return sum;

//}
//Console.Write("Input N: ");
//int n = Convert.ToInt32(Console.ReadLine());


//Напишите программу, которая выводит массив из n элементов, заполненный случайными числами в указанном диапазоне

//[1 0 1 1 0 1 0 0]

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
