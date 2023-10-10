// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0) 
    {
        sum+=num%10;
        num= num/10;
    } 
    return sum;

}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма всех чисел данной цифры {num} = {SumDigit(num)}");
