namespace HackerRank
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ArrayHelper
    {
        public static int TargetValue(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                    return target;

                if (arr[left] <= arr[mid])
                {
                    if(target >= arr[left] && target <= arr[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (target > arr[mid] && target <= arr[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
        public static IEnumerable<int> RemoveDuplicates(int[] arr)
        {
            var hash = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                hash.Add(arr[i]);
            }

            return hash;
        }

        public static void LargestAndSmallest(int[] arr)
        {
            var smallest = 0;
            var largest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                    largest = arr[i];
                else if (arr[i] < smallest)
                    smallest = arr[i];
            }

            Console.WriteLine(smallest);
            Console.WriteLine(largest);
        }
        public static IEnumerable<int> OrderDescending(int[] arr)
        {
            var orderedResult  = new List<int>();   
            var result = Sort.SortFunction(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                orderedResult.Add(result[i]);
            }

            return orderedResult;
        }
        public static void RotateLeft(int[] arr)
        {
            int n = arr.Length;
            int temp;

            for (int i = n - 1; i > 0; i--)
            {
                temp = arr[n - 1];
                arr[n - 1] = arr[i - 1];
                arr[i - 1] = temp;  
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        } 
        public static bool SubArrayExists(int[] arr)
        {
            var hs = new HashSet<int>();
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] == 0)
                    return true;
                else if (sum == 0)
                    return true;
                else if (hs.Contains(sum))
                    return true;

                hs.Add(sum);
            }

            return false;
        }
        //O(N) time
        public static void FindDuplicates(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                var ex = arr[i] % arr.Length;
                arr[ex] +=  arr.Length;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= arr.Length * 2)
                    Console.WriteLine(i + " ");
            }
        }
        public static void UnionBetween2Arrays(int[] arr1, int[] arr2)
        {
            int i = 0;
            int j = 0;
            int m = arr1.Length;
            int n = arr2.Length;

            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    Console.Write(arr1[i++] + " ");
                else if (arr2[j] < arr1[i])
                    Console.Write(arr2[j++] + " ");
                else
                {
                    Console.WriteLine(arr2[j++] + " ");
                    i++;
                }
            }

            while (i < m)
                Console.Write(arr1[i++] + " ");
            while (j < n)
                Console.Write(arr2[j++] + " ");
        }
        public static int[] MoveNegative(int[] arr)
        {

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }

            return arr;
        }
        public static int FindKElement(int[] arr, int k)
        {
            Sort.SortFunction(arr);

            return arr[k - 1];
        }
        public static void SmallerNeighbours(int[] arr)
        {
            var countResult = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i - 1] < arr[i] && (arr[i + 1]) < arr[i]))
                {
                    Console.WriteLine(arr[i]);
                    countResult++;
                }
            }
            if (countResult <= 0)
                Console.WriteLine("The array is in Ascending Order");
        }
        public static void SubArraySum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = arr[i];

                if (currentSum == sum)
                {
                    Console.WriteLine($"Sum founded at index " + i);
                    return;
                }
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        currentSum += arr[j];

                        if (currentSum == sum)
                        {
                            Console.WriteLine($"Sum found between: " + i + "and" + j);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"No subarray founded.");
        }
        public static IEnumerable<IEnumerable<int>> Split(int[] arr, int size)
        {
            for (var i = 0; i < arr.Length / size + 1; i++)
            {
                yield return arr.Skip(i * size).Take(size);
            }
        }
        public static IEnumerable<int> Flatten(int[][] arr) =>
          arr.SelectMany(x => x).ToArray();

        public static bool Equals(int[] arr, int[] arr2)
        {
            if (arr.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr2[i])
                    return true;
            }

            return false;
        }

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
