using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddEnvironment_Adds_expected_services()
    {
        ServiceCollection services = new();
        services.AddEnvironment();

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IEnvironment) &&
            sd.ImplementationType == typeof(EnvironmentAdapter) &&
            sd.Lifetime == ServiceLifetime.Transient);
    }
}