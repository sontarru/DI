using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddGuids_Adds_Expected_Services()
    {
        ServiceCollection services = new();
        services.AddGuids();

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IVGuidGenerator) &&
            sd.KeyedImplementationType == typeof(V4DefaultGuidGenerator) &&
            sd.Lifetime == ServiceLifetime.Transient &&
            sd.IsKeyedService &&
            sd.ServiceKey != null &&
            sd.ServiceKey.Equals(GuidVersion.V4));

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IVGuidGenerator) &&
            sd.KeyedImplementationType == typeof(V7DefaultGuidGenerator) &&
            sd.Lifetime == ServiceLifetime.Transient &&
            sd.IsKeyedService &&
            sd.ServiceKey != null &&
            sd.ServiceKey.Equals(GuidVersion.V7));

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IVGuidGeneratorProvider) &&
            sd.ImplementationType == typeof(VGuidGeneratorProvider) &&
            sd.Lifetime == ServiceLifetime.Transient);

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IGuidGenerator) &&
            sd.ImplementationType == typeof(GuidGenerator) &&
            sd.Lifetime == ServiceLifetime.Transient);
    }
}