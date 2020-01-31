using Xunit;

namespace codesignal.Tests
{
    public class ArrayTest
    {
        Arrays _arrays;

        public ArrayTest()
        {
            _arrays = new Arrays();
        }

        [Theory]
        [InlineData("abacabad", 'c')]
        [InlineData("abacabaabacaba", '_')]
        [InlineData("z", 'z')]
        public void FirstNotRepeatingCharacter_ShouldWork(string input, char expected)
        {
            var actual = _arrays.FirstNotRepeatingCharacter(input);

            Assert.Equal(expected, actual);
        }
    }
}