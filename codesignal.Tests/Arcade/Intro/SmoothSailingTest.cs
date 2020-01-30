using System;
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
        public void ReverseInParenthesis_All_ShouldWork(string input, string expected)
        {
            var actual = _smoothSailing.ReverseInParentheses(input);

            Assert.Equal(expected, actual);
        }
    }
}
