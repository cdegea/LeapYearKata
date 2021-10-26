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

        [Fact]
        public void Is1905LeapYear()
        {
            Assert.False(LeapYear.IsLeapYear(1905));
        }

        [Fact]
        public void Is1906LeapYear()
        {
            Assert.False(LeapYear.IsLeapYear(1906));
        }
    }
}
