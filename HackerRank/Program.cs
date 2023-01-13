internal class Program
{
    private static void Main(string[] args)
    {
        var a = new int[] {5, 6, 7 };
        var b = new int[] {3, 6, 10 };

        var expected = CompareTriplets(a, b);

        Console.WriteLine(string.Join(" ", expected.ToList()));
    }
    public static List<int> CompareTriplets(int[] a, int[] b)
    {

        var alicePoints = 0;
        var bobPoints = 0;

        var startIndex = 0;
        var endIndex = a.Length - 1;

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