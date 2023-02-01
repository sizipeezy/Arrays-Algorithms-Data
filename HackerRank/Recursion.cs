namespace HackerRank
{
    public static class Recursion
    {
        public static void DoubleArray(int[] arr, int index)
        {
            if (index >= arr.Length)
                return;

            arr[index] *= 2;
            DoubleArray(arr, index + 1);
        }
    }
}
