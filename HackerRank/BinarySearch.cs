namespace HackerRank
{

    public static class BinarySearch
    {
        public static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                return BinarySearchRecursive(arr, target, mid + 1, right);
            }
            else
            {
                return BinarySearchRecursive(arr, target, left, mid - 1);
            }
        }
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
