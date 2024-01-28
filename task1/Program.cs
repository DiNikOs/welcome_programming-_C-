// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();
string outputNaturalNumber(int m, int n)
{
    if (n == m)
        //return $"{n}";
        return $"{n}";
    return (m < n) ? outputNaturalNumber(m, n - 1) + $", {n}" : $"{m}, " + outputNaturalNumber(m - 1, n);
}

Console.WriteLine(outputNaturalNumber(4, 10));
Console.WriteLine(outputNaturalNumber(10, 4));

