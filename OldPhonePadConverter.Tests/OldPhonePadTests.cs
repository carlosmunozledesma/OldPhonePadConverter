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
        [InlineData("1#", "&")]
        [InlineData("11#", "'")]
        [InlineData("111#", "(")]
        [InlineData("1111#", "&")]
        [InlineData("*#", "")]
        [InlineData("22**#", "")]
        [InlineData("227**#", "")]
        [InlineData("0#", " ")]
        [InlineData("44033055505550666#", "H E L L O")]
        [InlineData("2A3#", "AD")]
        [InlineData("", "")]
        [InlineData("222", "")]
        [InlineData("4433555 555666096667775553###", "HELLO WORLD")]
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
