using System.ComponentModel.Design.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr ={{11, 2, 4},
                     {4 , 5, 6},
                     {10, 8, -12}};

        Console.WriteLine(DiagonalDifference(arr));
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