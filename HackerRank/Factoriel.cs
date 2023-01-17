namespace HackerRank
{
    using System.Numerics;


    public static class Factoriel
    {
        public static BigInteger extraLongFactorials(int n)
        {
            BigInteger result = 0;

            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }

            return n * extraLongFactorials(n - 1);
        }
    }
}
