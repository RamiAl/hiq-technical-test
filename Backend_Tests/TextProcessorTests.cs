using Backend.Services;

namespace Backend_Tests
{
    public class TextProcessorTests
    {
        [Theory]
        [InlineData("Hello hello HELLO world!", "foohellobar")]
        [InlineData("This is a test. This test is only a test.", "footestbar")]
        [InlineData("Hello hello HELLO", "foohellobar foohellobar foohellobar")]
        [InlineData("", "")]
        public void ProcessFileContentStatic_ReturnsExpectedResult(string input, string expectedSubstring)
        {
            // Act
            var result = TextProcessor.ProcessContent(input);

            // Assert
            Assert.Contains(expectedSubstring, result);
        }
    }
}