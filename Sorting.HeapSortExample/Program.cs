
int[] array = new int[] { 3, 7, 1, 4 };
Sort(array);
foreach (var i in array)
{
    Console.Write($"{i}-");
}


#region HeapSort

//void Sort(int[] arr)
//{
//    int length = arr.Length;
//    for (int i = length / 2 - 1; i >=0; i--)
//    {
//        Heapify(arr,length,i);
//    }

//    for (int i = length - 1 ; i >= 0; i--)
//    {
//        Swap(arr,0,i);
//        Heapify(arr,i,0);
//    }

//}





//void Heapify(int[] arr, int length, int i)
//{
//    int largest = i; //initialize largest as root
//    int left = i * 2 + 1;
//    int right = i * 2 + 2;

//    if (left < length && arr[left] > arr[largest])
//    {
//        largest = left;
//    }
//    if (right < length && arr[right] > arr[largest])
//    {
//        largest = right;
//    }

//    if (largest != i)
//    {
//        Swap(arr,i,largest);

//        Heapify(arr,length,largest);
//    }


//}

//void Swap(int[] arr,int i,int j)
//{
//    (arr[i], arr[j]) = (arr[j], arr[i]);
//}


#endregion



void Sort(int[] arrInts)
{
    int length = arrInts.Length;
    for (int i = arrInts.Length / 2 - 1; i >= 0; i--)
    {
        Heapify(arrInts,length, i);
    }

    for (int i = length-1; i >=0; i--)
    {
        Swap(arrInts,0,i);
        Heapify(arrInts,i,0);
    }
}



void Heapify(int[] arr, int length, int i)
{
    int largest = i;
    int left = i * 2 + 1;
    int right = i * 2 + 2;

    if (left < length && arr[largest] < arr[left])
    {
        largest = left;
    }

    if (right < length && arr[largest] < arr[right])
    {
        largest = right;
    }

    if (largest != i)
    {
        Swap(arr, i, largest);
        Heapify(arr,length,largest);
    }

}














void Swap(int[] arr, int i, int j)
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}