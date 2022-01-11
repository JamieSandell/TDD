using Xunit;

public class TestClass
{
    [Fact]
    void PassingAddNumbersTest()
    {
        Assert.Equal(4, Program.AddNumbers(2, 2));
    }

    [Fact]
    void FailingAddNumbersTest()
    {
        Assert.Equal(5, Program.AddNumbers(4, 2));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(7)]
    [InlineData(2)]
    void MyFirstTheory(int number)
    {
        Assert.True(Program.isOddNumber(number));
    }
}