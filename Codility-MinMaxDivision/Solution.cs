using System.Runtime.CompilerServices;

namespace Codility_MinMaxDivision
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int K, int M, int[] A)
        {
            int left = 0;
            int right = M * A.Length;
            int result = 0;
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                K >= RANGE_LOWEST_VALUE && K <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE - 1 && M <= RANGE_HIGHEST_VALUE / 10) 
            {
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (isPossible(K, A, mid))
                    {
                        result = mid;
                        right = mid - 1;
                    }
                    else
                        left = mid + 1;
                }
            }
           
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private bool isPossible(int K, int[] A, int largeSum)
        {
            int blocks = 0;
            int currentSum = 0;

            foreach (int num in A)
            {
                if (currentSum + num > largeSum)
                {
                    blocks++;
                    currentSum = num;
                }
                else
                    currentSum += num;
            }

            if (currentSum > 0)
                blocks++;

            return blocks <= K;
        }
    }
}
