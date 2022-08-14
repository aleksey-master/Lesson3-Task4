

Console.WriteLine("Сортировка массива по возрастанию");
int[] arr = { 1, 5, 4, 7, 6, 9, 5, 1, 1 };
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Начальный массив");
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < (array.Length - 1); i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectionSort(arr);
System.Console.WriteLine("Отсортированный массив");
PrintArray(arr);
