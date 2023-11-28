
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

int[] array = new int[] { 4, 6, 1, 7, 0, 11, 8, 5 };
//QuickSortHoare(array, 0, array.Length-1);
QuickSortLomuto(array, 0, array.Length - 1);

foreach (var i in array)
{
    Console.Write($"{i}-");
}

#region QuickSortHoare

void QuickSortHoare(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pivot = HoarePartition(arr, low, high);
        QuickSortHoare(arr, low, pivot);
        QuickSortHoare(arr, pivot + 1, high);
    }

}



int HoarePartition(int[] arr, int low, int high)
{
    int pivot = arr[low];
    int i = low - 1;
    int j = high + 1;

    while (true)
    {
        do
        {
            i++;
        } while (arr[i] < pivot);

        do
        {
            j--;
        } while (arr[j] > pivot);

        if (i >= j)
        {
            return j;
        }

        Swap(arr, i, j);

    }

    void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

}

#endregion

void QuickSortLomuto(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pivot = LomutoPartition(arr, low, high);
        QuickSortLomuto(arr, low, pivot - 1);
        QuickSortLomuto(arr, pivot + 1, high);
    }

}




int LomutoPartition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
        if (arr[j] <= pivot)
        {
            i++;
            if (i != j)
            {
                Swap(arr,i,j);
            }
        }
    }
    Swap(arr,i+1,high);
    return i + 1;
}




void Swap(int[] arr, int i, int j)
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}










