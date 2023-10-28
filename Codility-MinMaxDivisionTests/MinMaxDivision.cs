using Codility_MinMaxDivision;

namespace Codility_MinMaxDivisionTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        [InlineData(2, 10, new int[] { 1, 2, 3, 4, 5, 6 }, 11)]
        [InlineData(1, 5, new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        [InlineData(4, 1, new int[] { 1, 1, 1, 1, 1, 1 }, 2)]
        [InlineData(2, 10, new int[] { 10, 10, 10, 10, 10, 10 }, 30)]
        [InlineData(5, 1, new int[] { 1, 1, 1, 1, 1, 1 }, 2)]
        public void TestSolution(int K, int M, int[] A, int expected)
        {
            Solution solution = new Solution();
            int result = solution.solution(K, M, A);
            Assert.Equal(expected, result);
        }
    }
}