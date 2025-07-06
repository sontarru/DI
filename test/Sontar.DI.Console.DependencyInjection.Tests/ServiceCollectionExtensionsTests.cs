using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddConsole_Adds_Expected_Services()
    {
        ServiceCollection services = new();

        services.AddConsole();

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IConsoleText) &&
            sd.ImplementationType == typeof(ConsoleAdapter) &&
            sd.Lifetime == ServiceLifetime.Transient);

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IConsoleBinary) &&
            sd.ImplementationType == typeof(ConsoleAdapter) &&
            sd.Lifetime == ServiceLifetime.Transient);

        services.Should().Contain(sd =>
            sd.ServiceType == typeof(IConsoleKeyboard) &&
            sd.ImplementationType == typeof(ConsoleAdapter) &&
            sd.Lifetime == ServiceLifetime.Transient);
    }
}