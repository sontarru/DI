using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

public class VGuidGeneratorProviderTests
{
    [Fact]
    public void GetGuidGenerator_Returns_IVGuidGenerator()
    {
        ServiceCollection services = new();

        var vgg4 = A.Fake<IVGuidGenerator>();
        var vgg7 = A.Fake<IVGuidGenerator>();

        services.AddKeyedSingleton(GuidVersion.V4, vgg4);
        services.AddKeyedSingleton(GuidVersion.V7, vgg7);

        using var sp = services.BuildServiceProvider();

        VGuidGeneratorProvider sut = new(sp);

        sut.GetGuidGenerator(GuidVersion.V4).Should().Be(vgg4);
        sut.GetGuidGenerator(GuidVersion.V7).Should().Be(vgg7);
    }
}