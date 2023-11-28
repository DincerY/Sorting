var intArr = new[] {2,3,4,1,5,6,3,2 };
MergeSort(intArr,0,intArr.Length - 1);

Console.WriteLine(string.Join(",", intArr));

#region MergeSort

//void MergeSort<T>(T[] array, int left, int right) where T : IComparable
//{
//    if (left < right)
//    {
//        int middle = left + (right - left) / 2;

//        MergeSort<T>(array, left, middle);
//        MergeSort<T>(array, middle + 1, right);

//        Merge(array, left, middle, right);


//    }
//}
//void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
//{
//    int n1 = middle - left + 1;
//    int n2 = right - middle;

//    T[] leftArray = new T[n1];
//    T[] rightArray = new T[n2];

//    Array.Copy(array, left, leftArray, 0, n1);
//    Array.Copy(array, middle + 1, rightArray, 0, n2);

//    int leftIndex = 0, rightIndex = 0;
//    int k = left;

//    while (leftIndex < n1 && rightIndex < n2)
//    {
//        if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
//        {
//            array[k] = leftArray[leftIndex];
//            leftIndex++;
//        }
//        else
//        {
//            array[k] = rightArray[rightIndex];
//            rightIndex++;
//        }

//        k++;
//    }

//    while (leftIndex < n1)
//    {
//        array[k] = leftArray[leftIndex];
//        leftIndex++;
//        k++;
//    }

//    while (rightIndex < n2)
//    {
//        array[k] = rightArray[rightIndex];
//        rightIndex++;
//        k++;
//    }

//}

#endregion


void MergeSort(int[] array, int left, int right)
{
    if (left < right)
    {
        int middle = left + (right - left) / 2;
        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);
        MergeDeneme(array, middle, left, right);
    }
}

void MergeDeneme(int[] array, int middle, int left, int right)
{
    int a = middle - left + 1;
    int b = right - middle;
    int[] leftArray = new int[a];
    int[] rightArray = new int[b];

    Array.Copy(array, left, leftArray, 0, a);
    Array.Copy(array, middle + 1, rightArray, 0, b);

    int leftIndex = 0;
    int rightIndex = 0;
    int k = left;

    while (leftIndex < a && rightIndex < b)
    {
        if (leftArray[leftIndex] < rightArray[rightIndex])
        {
            array[k] = leftArray[leftIndex];
            leftIndex++;
        }

        else
        {
            array[k] = rightArray[rightIndex];
            rightIndex++;
        }

        k++;
    }

    while (leftIndex < a)
    {
        array[k] = leftArray[leftIndex];
        leftIndex++;
        k++;
    }
    while (rightIndex < b)
    {
        array[k] = rightArray[rightIndex];
        rightIndex++;
        k++;
    }

}





