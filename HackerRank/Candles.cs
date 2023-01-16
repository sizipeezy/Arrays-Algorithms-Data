namespace HackerRank
{
    using System.Collections.Generic;


    public static class Candles
    {
        public static int birthdayCakeWithoutDictionary(List<int> candles)
        {
            int max = 0;
            int sum = 0;
            int currentNumber = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                currentNumber = candles[i];
                if (currentNumber > max)
                {
                    sum = 1;
                    max = currentNumber;
                }
                else if (currentNumber == max)
                {
                    sum++;
                }
            }

            return sum;
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            var highesCandles = new Dictionary<int, int>();
            int currentHighest = 0;
            var finalSum = 0;

            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] >= currentHighest)
                {
                    currentHighest = candles[i];
                    if (!highesCandles.ContainsKey(currentHighest))
                    {
                        highesCandles.Add(currentHighest, 1);
                    }
                    else
                    {

                        highesCandles[currentHighest]++;
                    }


                }


            }

            foreach (var item in highesCandles)
            {
                finalSum += item.Value;
            }

            return finalSum;
        }
    }
}
