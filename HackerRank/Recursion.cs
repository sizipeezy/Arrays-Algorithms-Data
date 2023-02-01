namespace HackerRank
{
    public static class Recursion
    {
        public static string Reverse(string str)
        {
            if (str.Length <= 1) //the program base case
                return str;
            else
                return Reverse(str.Substring(1)) + str[0];
        }
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
