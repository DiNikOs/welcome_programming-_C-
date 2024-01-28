
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Отображаем перевёрнутый массив
int[] revertArrString(int[] arr)
{
    if (arr.Length == 0)
        return arr;
    Console.Write(arr[arr.Length - 1] + " ");
    Array.Resize(ref arr, arr.Length - 1);
    return revertArrString(arr);
}
// Создаём массив 
int[] ItemArr(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(1, 100);
    return arr;
}

int[] arr = ItemArr(10);
// Отображаем исходный массив
Console.WriteLine(String.Join(' ', arr));
// Отображаем перевёрнутый массив
Console.WriteLine(String.Join(' ', revertArrString(arr)));
