using System.Runtime.CompilerServices;

namespace Codility_ChocolatesByNumbers
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 1000000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int N, int M)
        {
            int chocolatesEaten = -1;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE &&
                M <= N
               ) 
            {
                long lcm = CalculateLCM(N, M);
                chocolatesEaten = (int)(lcm / M);
            }
            
            return chocolatesEaten;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        // Function to calculate the least common multiple (LCM) using GCD (Greatest Common Divisor)
        private long CalculateLCM(int a, int b)
        {
            long product = (long)a * (long)b;
            return product / CalculateGCD(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        // Function to calculate the Greatest Common Divisor (GCD) using Euclidean algorithm
        private int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
