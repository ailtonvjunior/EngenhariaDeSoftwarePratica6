using Utils;
using Xunit;

namespace inter.people.central.Tests.Utils
{
    public class ValidationUtilsTest
    {
        [Theory]
        [InlineData(10)]
        [InlineData("10")]
        [InlineData(10.0)]
        [InlineData('c')]
        public void TestingSucess_ValidateNullArgument(object? obj)
        {
            obj.ValidateNullArgument();
        }

        [Fact]
        public void TestingArgumentException_ValidateNullArgument()
        {
            object? obj = null;
            Assert.Throws<ArgumentException>(() => obj.ValidateNullArgument());
        }
    }
}
