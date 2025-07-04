namespace Sontar.DI;

public sealed class ConsoleAdapterTests
{
    [Fact]
    public void In_should_return_Console_In()
    {
        ConsoleAdapter sut = new();
        sut.In.Should().Be(Console.In);
    }

    [Fact]
    public void Out_should_return_Console_Out()
    {
        ConsoleAdapter sut = new();
        sut.Out.Should().Be(Console.Out);
    }

    [Fact]
    public void Error_should_return_Console_Error()
    {
        ConsoleAdapter sut = new();
        sut.Error.Should().Be(Console.Error);
    }
}
