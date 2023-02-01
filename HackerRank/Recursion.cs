namespace HackerRank
{
    public static class Recursion
    {
        public static int Sum(int[] arr, int n)
        {
            if (n <= 0)
                return 0;
            return (Sum(arr, n - 1) + arr[n - 1]);
        }
        public static void DoubleArray(int[] arr, int index)
        {
            if (index >= arr.Length)
                return;

            arr[index] *= 2;
            DoubleArray(arr, index + 1);
        }
    }
}
