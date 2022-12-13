// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SumMN(int numM, int numN)
{
    if (numM >= numN)
    {
        return numN;
    }
    numM += SumMN(numM + 1, numN);
    return numM;
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int sum = SumMN(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} равна: {sum}");