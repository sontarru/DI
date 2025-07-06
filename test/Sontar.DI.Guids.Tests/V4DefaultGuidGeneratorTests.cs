namespace Sontar.DI;

public class V4DefaultGuidGeneratorTests
{
    [Fact]
    public void NewGuid_Returns_Unique_Guids()
    {
        V4DefaultGuidGenerator sut = new();
        var actual = Enumerable.Repeat(0, 42).Select(_ => sut.NewGuid()).ToArray();
        actual.Should().OnlyHaveUniqueItems();
    }

    [Fact]
    public void NewGuid_Returns_V4_Guids()
    {
        V4DefaultGuidGenerator sut = new();
        var actual = sut.NewGuid();
        actual.Version.Should().Be(4);
    }
}