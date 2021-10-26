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
    }
}
