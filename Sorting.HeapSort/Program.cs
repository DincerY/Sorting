
int[] intArray = new[] { 7,6,5,9,11 };

HeapSort(intArray);

Console.WriteLine(string.Join(",", intArray));
Console.Read();

#region HeapSort

//void HeapSort(int[] array)
//{
//    int lenght = array.Length;

//    //Build Heap
//    for (int i = lenght / 2 - 1; i >= 0; i--)
//    {
//        Heapify(array, lenght, i);
//    }

//    //One by one extract an element from heap
//    for (int i = lenght - 1; i >= 0; i--)
//    {
//        (array[i], array[0]) = (array[0], array[i]);

//        Heapify(array, i, 0);
//    }


//}

//void Heapify(int[] array, int length, int i)
//{
//    int largest = i;
//    int left = 2 * i + 1;
//    int right = 2 * i + 2;

//    if (left < length && array[left] > array[largest])
//        largest = left;

//    if (right < length && array[right] > array[largest])
//    {
//        largest = right;
//    }

//    if (largest != i)
//    {
//        (array[largest], array[i]) = (array[i], array[largest]);

//        Heapify(array, length, largest);
//    }
//}

//-------------------------------------------------
//void HeapSort(int[] array)
//{
//    int length = array.Length;
//    //Crate Heap
//    for (int i = length / 2 - 1; i >= 0; i--)
//    {
//        DenemeHeapify(array, length, i);
//    }

//    for (int i = length - 1; i >= 0; i--)
//    {
//        (array[0], array[i]) = (array[i], array[0]);
//        DenemeHeapify(array, i, 0);
//    }

//}

//void DenemeHeapify(int[] array, int length, int i)
//{
//    int biggest = i;
//    int left = i * 2 + 1;
//    int right = i * 2 + 2;

//    if (left < length && array[biggest] < array[left])
//        biggest = left;
//    if (right < length && array[biggest] < array[right])
//        biggest = right;

//    if (biggest != i)
//    {
//        (array[i], array[biggest]) = (array[biggest], array[i]);
//        DenemeHeapify(array, length, biggest);
//    }
//}
#endregion


void HeapSort(int[] array)
{
    int length = array.Length;
    for (int i = length / 2 - 1; i >= 0; i--)
    {
        Heapify(array,length,i);
    }

    for (int i = length - 1; i >= 0; i--)
    {
        (array[i], array[0]) = (array[0], array[i]);
        Heapify(array,i,0);
    }
}

void Heapify(int[] array, int length ,int i)
{
    int biggest = i;
    int left = i * 2 + 1;
    int right = i * 2 + 2;

    if (left < length && array[biggest] < array[left]) 
        biggest = left;

    if (right < length && array[biggest] < array[right]) 
        biggest = right;

    if (biggest != i)
    {
        (array[i], array[biggest]) = (array[biggest], array[i]);
        Heapify(array,length,biggest);
    }
}

