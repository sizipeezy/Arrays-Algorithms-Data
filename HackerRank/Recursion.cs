namespace HackerRank
{
    public static class Recursion
    {
        public static void SumEven(int[] arr, int n, int sum)
        {
            if(n < 0)
            {
                Console.WriteLine(sum);
                return;
            }

            if ((arr[n]) % 2 == 0)
                sum += arr[n];

            SumEven(arr, n - 1, sum);

        }
        public static int NumberOfPaths(int n)
        {
            if (n < 0)
                return 0;
            else if (n == 1 || n == 0)
                return 1;

            return NumberOfPaths(n - 1) + NumberOfPaths(n - 2) + NumberOfPaths(n - 3);
        }
        public static int CountX(string input)
        {
            if (input.Length == 1)
                if (input[0] == 'x')
                    return 1;
                else
                    return 0;

            if (input[0] == 'x')
                return 1 + CountX(input.Substring(1));
            else
                return CountX(input.Substring(1));
        }
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
