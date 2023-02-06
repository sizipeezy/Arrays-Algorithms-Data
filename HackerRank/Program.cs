using BinarySearchTree;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 10, 4, 5, 8, 6, 11, 26 };
        int[] arraycopy = { 10, 4, 5, 8, 6, 11, 26 };
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine(string.Join(" ", FindLargestThree(array)));

        Console.WriteLine("----------------------largest on me----------");

        int kPosition = 3;
        int length = array.Length;

        if (kPosition > length)
        {
            Console.WriteLine("Index out of bound");
        }
        else
        {
            // find kth smallest value
            Console.WriteLine("K-th smallest element in array : " +
                                KthSmallest(arraycopy, 0, length - 1,
                                                        kPosition - 1));
        }
    }

    public static IEnumerable<int> FindLargestThree(int[] arr)
    {
        int first = 0;
        int second = 0;
        int third = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            // greater than first
            if (arr[i] > first)
            {
                third = second;
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                third = second;
                second = arr[i];
            }
            else if (arr[i] > third && arr[i] != second)
                third = arr[i];
        }

        var result = new List<int>();
        result.Add(first);
        result.Add(second);
        result.Add(third);
        return result;
    }
    public static int KthSmallest(int[] arr, int low, int high, int k)
    {
        int partition = Partitions(arr, low, high);

        if (partition == k)
            return arr[partition];
        else if (partition < k)
            return KthSmallest(arr, partition + 1, high, k);
        else
            return KthSmallest(arr, low, partition - 1, k);
        
    }
    public static int Partitions(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int pitotLow = low;
        int temp;

        for (int i = low; i <= high; i++)
        {
            if (arr[i] < pivot)
            {
                temp = arr[i];
                arr[i] = arr[pitotLow];
                arr[pitotLow] = temp;
                pitotLow++;
            }
        }

        temp = arr[high];
        arr[high] = arr[pitotLow];
        arr[pitotLow] = temp;

        return pitotLow;
    }

    public static double FindMedianSortedArrays(int[] num1, int[] nums2)
    {
        int m = num1.Length;
        int n = nums2.Length;

        var combined = new int[n + m];
        Array.Copy(num1, 0, combined, 0, m);
        Array.Copy(nums2, 0, combined, 0, n);
        Array.Sort(combined);

        int mid = (m + n) / 2;
        if((n+m) % 2 == 0)
        {
            return combined[mid - 1] + combined[mid] / 2.0;
        }
        else
        {
            return combined[mid];
        }
        
    }

    public static IEnumerable<int> RemoveDuplicates(int[] arr)
    {
        var result = new HashSet<int>();
        foreach (var item in arr)
        {
            if(!result.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
 
    public static string[] ReverseArray(string[] input)
    {
        var start = 0;
        var end = input.Length - 1;
        while (start < end)
        {
            var temp = input[start];
            input[start] = input[end];
            input[end] = temp;
            start++;
            end--;
        }
        return input;
    }
    public static void FindAllSubstrings(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            var sb = new StringBuilder(input.Length - 1);
            for (int j = 0; j < input.Length; j++)
            {
                sb.Append(input[j]);
                Console.Write(sb + " ");
            }
        }
    }
    public static void Find3x3Matrix(string input)
    {
        var arr = CreateRectangularMatrix(input);
        var current3x3Sum = int.MinValue;
        var startRow = 0;
        var startCol = 0;

        for (int row = 0; row < arr.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 2; col++)
            {
                int sum = arr[row, col] + arr[row + 1, col] + arr[row + 2, col]
                    + arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2]
                    + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                if (sum > current3x3Sum)
                {
                    current3x3Sum = sum;
                    startCol = col;
                    startRow = row;
                }
            }
        }

        Console.WriteLine($"Sum = {current3x3Sum}");
        for (int i = startRow; i <= startRow + 2; i++)
        {
            for (int j = startCol; j <= startCol + 2; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] CreateRectangularMatrix(string input)
    {
        var size = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var matrix = new int[size[0], size[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            var columns = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = columns[col];
            }
        }

        return matrix;
    }
    public static void Squares2x2Calculate(string input)
    {
        int[] dimensions = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

        int row = dimensions[0];
        int col = dimensions[1];

        char[,] matrix = new char[row, col];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            char[] columns = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(char.Parse)
                                    .ToArray();

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = columns[cols];
            }
        }

        int sumOfMatrix = 0;
        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols] &&
                    matrix[rows, cols] == matrix[rows + 1, cols + 1] &&
                    matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    sumOfMatrix++;
                }
            }
        }
        Console.WriteLine(sumOfMatrix);

    }
    public static void DiagnoalDifference(string input)
    {
        int n = int.Parse(input);

        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            var colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = colElements[col];
            }
        }


        var sum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == col)
                    sum += matrix[row, col];
            }
        }

        var sum2 = 0;
        int index = matrix.GetLength(1) - 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sum2 += matrix[row, index];
            index--;
        }

        int difference = Math.Abs(sum - sum2);
        Console.WriteLine(difference);
    }

    public static void Initiliaze(int[] A, int[] D)
    {
        int n = A.Length;

        D[0] = A[0];
        D[n] = 0;
        for (int i = 1; i < n; i++)
            D[i] = A[i] - A[i - 1];
    }
    public static int Print(int[] A, int[] D)
    {
        for (int i = 0; i < A.Length; i++)
        {

            if (i == 0)
                A[i] = D[i];
            else
                A[i] = D[i] + A[i - 1];

            Console.Write(A[i] + " ");
        }

        Console.WriteLine();

        return 0;
    }
    public static void Update(int[] arr, int start, int end, int value)
    {
        arr[start] += value;
        arr[end + 1] -= value;
    }
    public static int CalculateDigits(int[] arr)
    {
        var currentNum = 0;
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentNum = arr[i];
            sum += currentNum % 10;
            currentNum = currentNum / 10;

        }
        return sum;
    }
    public static List<int> Reverse(List<int> nums)
    {
        var result = new List<int>();

        for (int i = nums.Count - 1; i >= 0; i--)
        {
            result.Add(nums[i]);
        }
        return result;
    }
    public static void Square2x2Sum(string input)
    {
        var arr = ReadDimensionalArray(input);

        var currentSum = 0;
        var currentRow = 0;
        var currentCol = 0;

        for (int row = 0; row < arr.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 1; col++)
            {
                var squareSum = arr[row, col] + arr[row + 1, col] + arr[row, col + 1] + arr[row + 1, col + 1];
                if (squareSum > currentSum)
                {
                    currentSum = squareSum;
                    currentRow = row;
                    currentCol = col;
                }
            }
        }

        Console.WriteLine(arr[currentRow, currentCol] + " " + arr[currentRow, currentCol + 1]);
        Console.WriteLine(arr[currentRow + 1, currentCol] + " " + arr[currentRow + 1, currentCol + 1]);
        Console.WriteLine(currentSum);
    }
    public static int[,] ReadDimensionalArray(string input)
    {
        int[] size = input.Split(", ").Select(int.Parse).ToArray();

        int[,] matrix = new int[size[0], size[0]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] columns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = columns[col];
            }
        }

        return matrix;
    }
    public static int[,] ReadDimensionalArrayWithSymbols(int n)
    {
        int[,] matrix = new int[n, n];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            var symbols = Console.ReadLine();
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = symbols[cols];
            }
        }

        return matrix;
    }
    public static string FindSymbol(int n, char symbol)
    {
        var arr = ReadDimensionalArrayWithSymbols(n);

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == symbol)
                    return $"({i},{j})";
            }
        }

        return $"Not found";
    }
    public static int SumDiagonal(int[,] arr)
    {
        var sum = 0;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (row == col)
                {
                    sum += arr[row, col];
                    continue;
                }
            }
        }

        return sum;
    }
    public static void SumMatrixElements(int[] input)
    {
        int rows = input[0];
        int cols = input[1];

        int[,] matrix = new int[rows, cols];

        int sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] inputLine = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = inputLine[col];
                sum += matrix[row, col];
            }
        }

        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sum);

    }
    public static long Factoriel(int num)
    {
        if (num == 1)
            return 1;
        else
            return num * Factoriel(num - 1);
    }
    public static void CountDown(int num)
    {
        if (num == 0)
            return;

        Console.WriteLine(num);
        CountDown(num - 1);
    }
    public static char FirstNonDuplicate(string arr)
    {
        var dict = new Dictionary<char, int>();
        var result = 'b';

        foreach (var item in arr)
        {
            if (!dict.ContainsKey(item))
                dict.Add(item, 1);
            else
                dict[item]++;
        }

        foreach (var item in dict)
        {
            if (item.Value <= 1)
            {
                result = item.Key;
                break;
            }
        }
        return result;
    }
    public static string FirstDuplicate(string[] arr)
    {
        var dict = new Dictionary<string, int>();
        var result = string.Empty;

        foreach (var item in arr)
        {
            if (!dict.ContainsKey(item))
                dict.Add(item, 1);
            else
                dict[item]++;

            if (dict[item] > 1)
            {
                result = item;
                break;
            }
        }
        return result;
    }
    public static List<int> InterSection(int[] arr1, int[] arr2)
    {
        var dict = new Dictionary<int, int>();
        var result = new List<int>();

        foreach (var item in arr1)
        {
            if (!dict.ContainsKey(item))
                dict.Add(item, 1);
            else
                dict[item]++;
        }

        foreach (var item in arr2)
        {
            if (dict.ContainsKey(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
    public static List<string> StringBuilder(string[] arr)
    {
        var result = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                    result.Add(arr[i] + arr[j]);
            }
        }

        return result;
    }
    public static bool ContainsX(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'x')
                return true;
        }

        return false;
    }
    public static bool SumTwo(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == 10)
                    return true;

                //if (i != j && arr[i] + arr[j] == 10)
                //     return true;
            }

        }

        return false;
    }
    public static int BeautifulDays(int i, int j, int k)
    {
        int counter = 0;
        for (int p = i; p <= j; p++)
        {
            int result = GetDiff(p);
            if (result % k == 0)
                counter++;
        }

        return counter;
    }

    public static int GetDiff(int value)
    {
        int temp = value;
        int reverse = 0;

        while (temp > 0)
        {
            reverse = reverse * 10;
            reverse += temp % 10;
            temp = temp / 10;
        }
        return Math.Abs(value - reverse);
    }

    public static string AngryProfessor(int k, List<int> a)
    {
        var result = new List<int>();

        foreach (var item in a)
        {
            if (item <= 0)
                result.Add(item);
        }

        if (result.Count >= k)
            return "NO";
        else
            return "YES";
    }

    public static int BirdsCount(int n, int[] arr)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]]++;
            }

        }

        var smallest = 0;

        foreach (var item in dict)
        {
            if (item.Value > smallest)
            {
                smallest = item.Key;
            }
        }

        return smallest;
    }
    public static int divisibleSumPairs(int n, int k, int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((arr[i] + arr[j]) % k == 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
    public static int BinarySearch(int[] arr, int element)
    {
        var lowerIndex = 0;
        var highIndex = arr.Length - 1;


        while (lowerIndex <= highIndex)
        {
            var mid = (lowerIndex + highIndex) / 2;

            var valueMid = arr[mid];

            if (element == valueMid)
                return mid;
            else if (element < valueMid)
            {
                highIndex = mid--;
            }
            else if (element > valueMid)
            {
                lowerIndex = mid++;
            }

        }

        return element;
    }

    public static int SortedSearch(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
                return arr[i];
            else if (arr[i] > element)
                return -1;
        }

        return -1;
    }
    public static int GamesCount(int p, int d, int m, int s)
    {
        int gameCount = 0;

        while (s >= 0)
        {

            s -= p;
            p -= d;

            if (p < m)
            {
                p = m;
            }

            gameCount++;
        }

        return gameCount - 1;
    }
    public static int DistanceBetweenIndex(List<int> arr)
    {
        var min = arr.Count;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[i] == arr[j])
                {
                    if (j - i < min)
                    {
                        min = j - i;
                    }

                }
            }
        }

        if (min == arr.Count)
        {
            return -1;
        }
        return min;
    }
    public static bool IsPalindrome(string input)
    {
        int leftIndex = 0;
        int rightIndex = input.Length - 1;
        int mid = input.Length / 2;

        while (leftIndex < mid)
        {
            if (input[leftIndex] != input[rightIndex])
                return false;

            leftIndex++;

            rightIndex--;
        }

        return true;
    }
    public static void WordBuilder(string[] arr)
    {
        var resultCollection = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                    resultCollection.Add(arr[i] + arr[j]);
            }
        }

        foreach (var item in resultCollection)
        {
            Console.WriteLine(item);
        }

    }
    public static int findDigits(int n)
    {
        int counter = 0;
        int cp = n;
        while (n != 0)
        {
            int rm = n % 10;
            if (rm > 0 && cp % rm == 0)
                counter++;

            n /= 10;
        }

        return counter;
    }
    public static int hurdleRace(int k, List<int> height)
    {

        var tallest = height[0];

        for (int i = 0; i < height.Count; i++)
        {
            if (height[i] > tallest)
            {
                tallest = height[i];
            }
        }

        return Math.Max(0, tallest - k);
    }

    public static int Solve(List<int> choclateBarValues, int birthday, int birthMonth)
    {
        var totalWays = 0;

        if (choclateBarValues.Count >= birthMonth)
        {
            var barPartSum = 0;
            for (int i = 0; i < birthMonth; i++)
                barPartSum += choclateBarValues[i];

            if (barPartSum == birthday)
                totalWays++;

            for (int i = 0; i < choclateBarValues.Count - birthMonth; i++)
            {
                barPartSum -= choclateBarValues[i] + choclateBarValues[i + birthMonth];

                if (barPartSum == birthday)
                    totalWays++;
            }
        }
        return totalWays;
    }

    public static int FactorielSimply(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        if (number == 1)
        {
            return 1;
        }

        return number * FactorielSimply(number - 1);
    }
    public static void ReverseNumber(int n)
    {
        int reverseNumber = 0;

        while (n != 0)
        {
            reverseNumber *= 10;
            reverseNumber += n % 10;
            n = n / 10;
        }

        Console.WriteLine(reverseNumber);
    }
    public static string Reverse(string Input)
    {
        char[] charArray = Input.ToCharArray();

        string reversedString = String.Empty;

        for (int i = charArray.Length - 1; i > -1; i--)
        {
            reversedString += charArray[i];
        }

        return reversedString;
    }

    public static void miniMaxSum(List<int> arr)
    {
        int sum = 0;
        int max = arr.Max();
        int min = arr.Min();
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
        }
        Console.Write("{0} {1}", sum - max, sum - min);
    }
    public static void ConsoleStair(int n)
    {
        for (int y = n - 1; y >= 0; y--)
        {
            for (int x = 0; x < n; x++)
            {
                if (x >= y)
                    Console.Write('#');
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    public static void Test(List<int> arr)
    {
        int len = arr.Count;

        // Initialize the positiveCount, negativeCount, and
        // zeroCountby 0 which will count the total number
        // of positive, negative and zero elements
        float positiveCount = 0;
        float negativeCount = 0;
        float zeroCount = 0;

        // Traverse the array and count the total number of
        // positive, negative, and zero elements.
        for (int i = 0; i < len; i++)
        {
            if (arr[i] > 0)
            {
                positiveCount++;
            }
            else if (arr[i] < 0)
            {
                negativeCount++;
            }
            else if (arr[i] == 0)
            {
                zeroCount++;
            }
        }

        // Print the ratio of positive,
        // negative, and zero elements
        // in the array up to four decimal places.
        Console.WriteLine("{0:F6} ", positiveCount / len);
        Console.WriteLine("{0:F6} ", negativeCount / len);
        Console.WriteLine("{0:F6} ", zeroCount / len);
    }
    public static void plusMinus(List<int> arr)
    {
        decimal minus = 0;
        decimal plus = 0;
        decimal zero = 0;

        foreach (var item in arr)
        {
            if (item < 0)
                minus++;
            else if (item > 0)
                plus++;
            else if (item == 0)
                zero++;
        }

        var minusRatio = minus / arr.Count;
        var plusRatio = plus / arr.Count;
        var zeroRatio = zero / arr.Count;

        Console.WriteLine("{0:F6} ", minusRatio);
        Console.WriteLine("{0:F6} ", plusRatio);
        Console.WriteLine("{0:F6} ", zeroRatio);

    }

    public static void ReverseAString(char[] arr)
    {
        for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
        {
            arr[i] = arr[j];
            arr[j] = arr[i];
        }

    }
    public static int DiagonalDifferenceWithLists(List<List<int>> arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            result += arr[i][i] - arr[i][arr.Count - 1 - i];
        }

        return Math.Abs(result);
    }
    public static int DiagonalDifference(int[,] arr)
    {
        var d1 = 0;
        var d2 = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            d1 += arr[i, i];
        }

        int counter = arr.GetLength(1) - 1;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            d2 += arr[i, counter];
            counter--;
        }

        return Math.Abs(d1 - d2);
    }
    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        foreach (var item in ar)
        {
            sum += item;
        }

        return sum;
    }

    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {

        var alicePoints = 0;
        var bobPoints = 0;

        var startIndex = 0;
        var endIndex = a.Count - 1;

        var result = new List<int>();

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (a[i] == b[i])
            {
                continue;
            }

            if (a[i] > b[i])
            {
                alicePoints++;
            }
            else
            {
                bobPoints++;
            }
        }

        result.Add(alicePoints);
        result.Add(bobPoints);

        return result;
    }
}