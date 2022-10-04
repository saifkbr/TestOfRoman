using RomanNumeralsTestApp;

namespace RomanNumeralsApp.UnitTest;

public class ConverterTest
{
    [Theory]
    [InlineData(10)]
    public void Convert_ValidIntegerInput_ShouldReturnString(int number)
    {
        // Arrange
        IntToRomanConverter converter = new IntToRomanConverter();

        // Act
        string result = converter.Convert(number);

        // Assert
        Assert.IsType<string>(result);
    }

    [Theory]
    [InlineData(2, "II")]
    [InlineData(5, "V")]
    [InlineData(1999, "MCMXCIX")]
    public void Convert_Integer_ToRomanNumeral(int number, string expectedRomanNumeral)
    {
        // Arrange
        IntToRomanConverter converter = new IntToRomanConverter();

        // Act
        string actualRomanNumeral = converter.Convert(number);

        // Assert
        Assert.Equal(expectedRomanNumeral, actualRomanNumeral);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2000)]
    public void Convert_ThrowsExceptionIfNotFound(int number)
    {
        // Arrange
        IntToRomanConverter converter = new IntToRomanConverter();

        // Act
        Assert.Throws<Exception>(() => converter.Convert(number));
    }
}
