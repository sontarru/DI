namespace Sontar.DI;

public class V7DefaultGuidGeneratorTests
{
    [Fact]
    public void NewGuid_Returns_Unique_Guids()
    {
        V7DefaultGuidGenerator sut = new();
        var actual = Enumerable.Repeat(0, 42).Select(_ => sut.NewGuid()).ToArray();
        actual.Should().OnlyHaveUniqueItems();
    }

    [Fact]
    public void NewGuid_Returns_V7_Guids()
    {
        V7DefaultGuidGenerator sut = new();
        var actual = sut.NewGuid();
        actual.Version.Should().Be(7);
    }
}