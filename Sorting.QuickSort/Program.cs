using System.Threading.Channels;

int[] array = new[] { 7, 4, 9, 6, 3 };
QuickSortHoare(array, 0, array.Length - 1);



foreach (var i in array)
{
    Console.Write($"{i} - ");
}

void QuickSortLomuto<T>(T[] array, int low, int high) where T : IComparable
{
    if (low < high)
    {
        var partitionIndex = PartitionLomuto(array, low, high);

        QuickSortLomuto<T>(array, low, partitionIndex - 1);
        QuickSortLomuto<T>(array, partitionIndex + 1, high);
    }
}

int PartitionLomuto<T>(T[] array, int low, int high) where T : IComparable
{
    var pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (array[j].CompareTo(pivot) < 0)
        {
            i++;
            Swap(array, i, j);
        }
    }
    Swap(array, i + 1, high);
    return i + 1;
}


//--------------------------------------------------------------------------//

void QuickSortHoare<T>(T[] array, int low, int high) where T : IComparable
{
    if (low < high)
    {
        var partitionIndex = PartitionHoare(array, low, high);

        QuickSortHoare<T>(array, low, partitionIndex);
        QuickSortHoare<T>(array, partitionIndex + 1, high);
    }
}

int PartitionHoare<T>(T[] array, int low, int high) where T : IComparable
{
    var pivot = array[low];
    int i = low - 1; int j = high + 1;

    while (true)
    {
        do
        {
            i++;
        } while (array[i].CompareTo(pivot) < 0);
        do
        {
            j--;
        } while (array[j].CompareTo(pivot) > 0);

        if (i >= j)
            return j;

        Swap(array, i, j);
    }
}

void Swap<T>(T[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}




void Deneme(int[] array, int low, int high)
{
    if (low < high)
    {
        var partitionPivot = PartitionHoareDeneme(array, low, high);

        Deneme(array, low, partitionPivot - 1);
        Deneme(array,partitionPivot + 1, high);
    }
}



int PartitionHoareDeneme(int[] array, int low, int high)
{
    int pivot = array[low];
    int i = low - 1, j = high + 1;
    while (true)
    {
        do
        {
            i++;
        } while (array[i] < pivot);

        do
        {
            j--;
        } while (array[j] > pivot);

        if (i >= j)
        {
            return j;
        }
        (array[i], array[j]) = (array[j], array[i]);
    }
}

int PartitionLomutoDeneme(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
        if (array[j] < pivot)
        {
            i++;
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
    (array[i+1], array[high]) = (array[high], array[i+1]);
    return i + 1;


}











