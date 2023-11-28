
int[] array = new int[]{8,7,4,5};
MergeSort(array,0,array.Length-1);
foreach (var i in array)
{
    Console.Write($"{i}-");
}

void MergeSort(int[] arr, int left, int right)
{
    if (left<right)
    {
        int middle = left+(right - left) / 2;
        MergeSort(arr,left,middle);
        MergeSort(arr,middle+1,right);
        Merge(arr,left,middle,right);
    }
}







void Merge(int[] arr,int left,int middle,int right)
{
    int a = middle - left + 1;
    int b = right-middle;

    int[] leftArray = new int[a];
    int[] rightArray = new int[b];

    Array.Copy(arr, left, leftArray, 0, a);
    Array.Copy(arr, middle + 1, rightArray, 0, b);

    int leftIndex = 0;
    int rightIndex = 0;
    int k = left;

    while (leftIndex < a && rightIndex < b)
    {
        if (leftArray[leftIndex] < rightArray[rightIndex])
        {
            arr[k] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            arr[k] = rightArray[rightIndex];
            rightIndex++;
        }

        k++;
    }

    while (leftIndex < a)
    {
        arr[k] = leftArray[leftIndex];
        leftIndex++;
        k++;
    }

    while (rightIndex < b)
    {
        arr[k] = rightArray[rightIndex];
        rightIndex++;
        k++;
    }





}