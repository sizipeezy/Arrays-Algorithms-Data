namespace HackerRank
{
    using System.Collections.Generic;
    using System.Linq;


    public class ArrayHelper
    {
        public static List<int> Unique(int[] arr)
        {
            var result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (result.Contains(arr[i]))
                    break;
                else
                    result.Add(arr[i]);

            }

            return result;
        }

        public static List<int> Reverse(int[] arr)
        {
            var result = new List<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result.Add(arr[i]);
            }

            return result;
        }

        public static char[] ValuesGenerator(int size, char item)
        {
            var arr = new char[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] += item;
            }

            return arr;
        }

        public static List<int> CompactClearer(string[] arr)
        {
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (item.OfType<int>() != null)
                {
                    var res = int.TryParse(item, out var success);

                    if (res == false)
                        continue;

                    result.Add(success);
                }
            }

            return result;
        }

        public static List<int> Without(int[] arr, int[] values)
        {
            var result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!values.Contains(arr[i]))
                    result.Add(arr[i]);
            }

            return result;
        }
    }
}
