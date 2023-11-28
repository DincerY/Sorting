

int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4 };
SelectionSort<int>(numbers);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
void SelectionSort<T>(T[] array) where T : IComparable
{
    for (int i = 0; i < array.Length; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j].CompareTo(array[minIndex]) < 0)
            {
                minIndex = j;
            }
        }
        var temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}
