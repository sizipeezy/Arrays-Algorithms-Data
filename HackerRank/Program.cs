﻿using HackerRank;
using System.ComponentModel.Design.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {

        // var arr = new int[] { 3,1,5, 10, 7 };
        // Sort.InsertionSort(arr);


        //Sort.SelectionSort(arr);
        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);
        //}

        var words = new string[] { "a", "b", "c", "d" };

        WordBuilder(words);


        string input = "racecar";
        Console.WriteLine(IsPalindrome(input));
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
    public static  void ReverseNumber(int n)
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
        for (int y = n - 1; y >= 0 ; y--)
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
            if(item < 0)
                minus++;
            else if(item > 0)
                plus++; 
            else if(item == 0)
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