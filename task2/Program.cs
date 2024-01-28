// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// через определения Петер
//  f ( n ) := A ( n , n )
// A(0, m)         =   m + 1
// A(n + 1, 0)     =   A(n, 1)
// A(n + 1, m + 1) =   A(n, A(n + 1, m))

// n = 0, m = 0 -> A(n,m) = 1
// n = 1, m = 1 -> A(n,m) = 3
// n = 2, m = 2 -> A(n,m) = 7
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29
// n = 3, m = 3 -> A(n,m) = 61
// n = 3, m = 4 -> A(n,m) = 125
// n = 3, m = 5 -> A(n,m) = 253


int recAckerman(int n, int m)
{
    if (n == 0 && m == 0)
        return 1;  
    if (n == 0)
        return m + 1;
    else if (m == 0)     
        return recAckerman(n - 1, 1);
    else
        return recAckerman(n - 1, recAckerman(n, m - 1));
}

int getNumFromConsole(string num)
{
    Console.Write($"Введите число {num} функции Аккермана A(n, m) (выход - q): ");
    string r = Console.ReadLine();
    if (r == "q")
        return -1;
    return int.Parse(r);
}


// Ввод начений из консоли
void PrintResult()
Console.Clear();
{
    while (true)
    {
        int n = getNumFromConsole("n");

        if (n == -1)
            return;

        if (n > 4)
        {
            Console.Write($"Введённое число n для функции Аккермана A({n}, m) слишком большое для выпонения через рекурсию!");
            return;
        }

        int m = getNumFromConsole("m");

        if (m == -1)
            return;

        if (n > 3 && m > 0)
        {
            Console.Write($"Введённые числа для функции Аккермана A({n}, {m}) слишком большие для выпонения через рекурсию!");
            return;
        }
        Console.WriteLine($"Функция Аккермана А({n}, {m}) = {recAckerman(n, m)}");
    }
}

Console.Clear();
Console.WriteLine();
// Вывод в консоль функции Аккермана до А(3, 6)
for (int n = 0; n < 4; n++)
{
    for (int m = 0; m < 7; m++)
    {
        Console.WriteLine($"Функция Аккермана А({n}, {m}) = {recAckerman(n, m)}");;
    }
    Console.WriteLine();
}


