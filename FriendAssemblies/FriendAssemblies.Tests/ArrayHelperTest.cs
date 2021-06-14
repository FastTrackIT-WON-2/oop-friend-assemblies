using FriendAssemblies.Library;
using System;
using Xunit;

namespace FriendAssemblies.Tests
{
    public class ArrayHelperTest
    {
        [Fact]
        public void ConvertToIntArray_When_StringArrayIsNull_Expected_ReturnsEmptyIntArray()
        {
            // Arrange (prepare data for tests)
            string[] stringArray = null;

            // Act (do the actual stuff)
            int[] intArray = ArrayHelper.ConvertToIntArray(stringArray);

            // Assert (verify that it worked as expected)
            Assert.NotNull(intArray);
            Assert.Empty(intArray);
        }
    }
}
