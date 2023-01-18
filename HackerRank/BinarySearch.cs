namespace HackerRank
{
    using System;


    public static class BinarySearch
    {
        public static int Binary(int[] arr, int searchValue)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == arr[mid])
                {
                    return ++mid;
                }
                else if (searchValue < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return searchValue;
        }
    }
}
