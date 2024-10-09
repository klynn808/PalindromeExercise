using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("1234", false)]
        [InlineData("123454321", true)]
        [InlineData("house", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
