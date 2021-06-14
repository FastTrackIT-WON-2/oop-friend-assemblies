using FriendAssemblies.Library;
using System;
using Xunit;

namespace FriendAssemblies.Tests
{
    public class StringToIntConverterTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        public void ConvertStringToInt_When_StringIsNull_ReturnsDefaultValue(int defaultValue)
        {
            // Arrange (prepare data for tests)
            string str = null;

            // Act (do the actual stuff)
            int convertedValue = StringToIntConverter.ConvertStringToInt(str, defaultValue);

            // Assert (verify that it worked as expected)
            Assert.Equal(defaultValue, convertedValue);
        }
    }
}
