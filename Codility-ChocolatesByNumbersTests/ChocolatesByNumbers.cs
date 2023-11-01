using Codility_ChocolatesByNumbers;

namespace Codility_ChocolatesByNumbersTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_ShouldReturnExpectedResult_WhenNMValid()
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(10, 4);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Solution_ShouldReturnMinusOne_WhenMIsGreaterThanN()
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(5, 10);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solution_ShouldReturnN_WhenMIsOne()
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(7, 1);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Solution_ShouldReturnZero_WhenNIsOutOfRange()
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(0, 3);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solution_ShouldReturnZero_WhenMIsOutOfRange()
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(100, 1000000001);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}