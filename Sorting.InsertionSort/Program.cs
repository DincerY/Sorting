using System.Runtime.InteropServices.JavaScript;

string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4, 10, 8 };

InsertionSortDeneme(numbers);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}


#region InsertionSort

void InsertionSort<T>(T[] array) where T : IComparable
{
    for (int i = 1; i < array.Length; i++)
    {
        T key = array[i];
        int j = i - 1;
        while (j >= 0 && array[j].CompareTo(key) > 0)
        {
            array[j + 1] = array[j];
            j--;

        }
        array[j + 1] = key;
    }

}

#endregion

void InsertionSortDeneme(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
    }
}



