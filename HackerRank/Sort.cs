using System;

namespace HackerRank
{
    public static class Sort
    {
        static void QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(nums, left, right);
                QuickSort(nums, left, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right];
            int i = left - 1;
            for (int j = left; j <= right - 1; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            Swap(nums, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
       
        public static void InsertionSortt(int[] arr)
        {
            int n = arr.Length;
            int val = 0;
            for (int i = 1; i < n; i++)
            {
                val = arr[i];
                for (int j = i - 1; j >= 0;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public static int[] SelectionSort(int[] array)
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
        public static int[] SortFunction(int[] arr)
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

            return arr;
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
