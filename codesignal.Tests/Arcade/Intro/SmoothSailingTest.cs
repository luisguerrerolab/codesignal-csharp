using System;
using System.Collections.Generic;
using Xunit;

namespace codesignal.Tests
{
    public class SmoothSailingTest
    {
        readonly SmoothSailing _smoothSailing;

        public SmoothSailingTest() {
            _smoothSailing = new SmoothSailing();
        }

        [Theory]
        [InlineData("(bar)", "rab")]
        [InlineData("foo(bar)baz", "foorabbaz")]
        [InlineData("foo(bar)baz(blim)", "foorabbazmilb")]
        [InlineData("()", "")]
        [InlineData("(()())", "")]
        public void ReverseInParenthesis_ShouldWork(string input, string expected)
        {
            var actual = _smoothSailing.ReverseInParentheses(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetData_AlternatingSums()
        {
            yield return new object[] { new int[] {50, 60, 60, 45, 70}, new int[] {180, 105} };
            yield return new object[] { new int[] {100, 50}, new int[] {100, 50} };
            yield return new object[] { new int[] {80}, new int[] {80, 0} };
        }

        [Theory]
        [MemberData(nameof(GetData_AlternatingSums))]
        public void AlternatingSums_ShouldWork(int[] input, int[] expected)
        {
            var actual = _smoothSailing.AlternatingSums(input);

            Assert.Equal(expected, actual);
        }
    }
}
