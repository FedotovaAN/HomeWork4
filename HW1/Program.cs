// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int FindDegree(int num, int digr)
{
    int degree = 1;
    for (int i=0; i< digr; i++) 
    {
        degree*= num;
    } 
    return degree;
}
bool ValidateExponent(int digr)
{
    if (digr < 0)
    {
        Console.Write("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input digr: ");
int digr = Convert.ToInt32(Console.ReadLine());

if (ValidateExponent(digr))
{
    Console.Write($"число {num} в степени {digr} равно {FindDegree(num, digr)}");
}
