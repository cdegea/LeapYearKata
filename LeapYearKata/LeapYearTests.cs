using Xunit;

namespace LeapYearKata
{
    public class LeapYearTests
    {
        [Fact]
        public void Is1904LeapYear()
        {
            Assert.True(LeapYear.IsLeapYear(1904));
        }

        [Theory]
        [InlineData (1905)]
        [InlineData(1906)]
        [InlineData(1907)]
        public void IsNotLeapYear(int year)
        {
            Assert.False(LeapYear.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1900)]
        public void IsDivisibleBy100(int year)
        {
            Assert.False(LeapYear.IsLeapYear(year));
        }

        [Theory]
        [InlineData(800)]
        [InlineData(1200)]
        [InlineData(1600)]
        public void IsNumberDivisibleBy400(int year)
        {
            Assert.True(LeapYear.IsLeapYear(year));
        }
    }
}
