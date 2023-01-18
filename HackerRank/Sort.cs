using System;

namespace HackerRank
{
    public static class Sort
    {
        public static int[]  SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var lowestNumberIndex = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[lowestNumberIndex])
                    {
                        lowestNumberIndex = j;
                    }
                }
                if (lowestNumberIndex != i)
                {
                    var temp = array[i];
                    array[i] = array[lowestNumberIndex];
                    array[lowestNumberIndex] = temp;
                }
            }
            return array;
        }
        public static void SortFunction(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                    
            }
        }

        public static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
