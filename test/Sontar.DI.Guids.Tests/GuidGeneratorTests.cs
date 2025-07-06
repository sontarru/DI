using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

public class GuidGeneratorTests
{
    [Fact]
    public void NewGuid_Returns_Guid()
    {
        var guidVersion = (GuidVersion)42;
        var expected = new Guid("fb0a385e-c614-4ac9-ae31-1cbb269ba93f");

        var vGuidGeneratorProvider = A.Fake<IVGuidGeneratorProvider>();
        var vGuidGenerator = A.Fake<IVGuidGenerator>();

        A.CallTo(() => vGuidGeneratorProvider.GetGuidGenerator(guidVersion))
            .Returns(vGuidGenerator);

        A.CallTo(() => vGuidGenerator.NewGuid()).Returns(expected);

        GuidGenerator sut = new(vGuidGeneratorProvider);
        var actual = sut.NewGuid(guidVersion);

        actual.Should().Be(expected);
    }

    /// <summary>
    /// Validates that <see cref="GuidGenerator.NewGuid(GuidVersion)"/> returns uniquie guids of
    /// expected versions.
    /// </summary>
    [Fact]
    public void NewGuid_IntegrationTest()
    {
        ServiceCollection services = new();
        services.AddGuids();
        using var sp = services.BuildServiceProvider();
        var sut = sp.GetRequiredService<IGuidGenerator>();

        var guids = Enumerable.Repeat(0, 42).Select(_ => sut.NewGuid()).ToArray();
        var guids4 = Enumerable.Repeat(0, 42).Select(_ => sut.NewGuid(GuidVersion.V4)).ToArray();
        var guids7 = Enumerable.Repeat(0, 42).Select(_ => sut.NewGuid(GuidVersion.V7)).ToArray();

        guids.Should().OnlyHaveUniqueItems();
        guids4.Should().OnlyHaveUniqueItems();
        guids7.Should().OnlyHaveUniqueItems();

        guids.Should().AllSatisfy(g => g.Version.Should().Be(4));
        guids4.Should().AllSatisfy(g => g.Version.Should().Be(4));
        guids7.Should().AllSatisfy(g => g.Version.Should().Be(7));
    }
}