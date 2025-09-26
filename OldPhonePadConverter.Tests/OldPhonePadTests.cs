using Xunit;

namespace OldPhonePadConverter.Tests
{
    public class OldPhonePadTests
    {
        // Fact
        [Theory]
        [InlineData("222 2 22#", "CAB")]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        [InlineData("227*", "")]
        [InlineData("444777666 66#", "IRON")]
        public void OldPhonePadConverterExpectedText(string input, string expected)
        {
            // Arrange

            // Act
            var result = OldPhonePadConverter.OldPhonePad(input);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
