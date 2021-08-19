using System;
using Xunit;
using NumberToEnglishKata;

namespace NumberToEnglishKata_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "One")]
        [InlineData(115, "Five")]
        [InlineData(29, "Nine")]
        [InlineData(0, "Zero")]
        [InlineData(10, "")]
        [InlineData(-111, "One")]
        public void TestSingleDigit(double num, string expected)
        {
            Assert.Equal(expected, NumberToEnglish.SingleDigit(num));
        }

        [Theory]
        [InlineData(10, "Ten")]
        [InlineData(13, "Thirteen")]
        [InlineData(19, "Nineteen")]
        [InlineData(115, "Fifteen")]
        [InlineData(20, null)]
        [InlineData(9, "Nine")]
        public void TestDoubleDigitTeens(double num, string expected)
        {
            Assert.Equal(expected, NumberToEnglish.DoubleDigitTeens(num));
        }

        [Theory]
        [InlineData(0, "Zero")]
        [InlineData(21, "Twenty-One")]
        [InlineData(90, "Ninty")]
        [InlineData(10, "Ten")]
        [InlineData(99, "Ninty-Nine")]
        [InlineData(100, null)]
        public void TestDoubleDigit(double num, string expected)
        {
            Assert.Equal(expected, NumberToEnglish.DoubleDigit(num));
        }

        [Theory]
        [InlineData(100, "One Hundred")]
        [InlineData(121, "One Hundred Twenty-One")]
        [InlineData(111, "One Hundred Eleven")]
        [InlineData(101, "One Hundred One")]
        [InlineData(999, "Nine Hundred Ninty-Nine")]
        public void TestTripleDigit(double num, string expected)
        {
            Assert.Equal(expected, NumberToEnglish.TripleDigit(num));
        }
    }
}
