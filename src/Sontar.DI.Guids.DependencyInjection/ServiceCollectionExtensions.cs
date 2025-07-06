using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

/// <summary>
/// Extension methods for the <see cref="IServiceCollection"/> interface.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds default implementation for <see cref="IGuidGenerator"/>.
    /// </summary>
    /// <param name="services">
    /// The dependency injection container to add the implementations to.
    /// </param>
    /// <returns>The value of <paramref name="services"/>.</returns>
    public static IServiceCollection AddGuids(this IServiceCollection services) =>
        services.AddKeyedTransient<IVGuidGenerator, V4DefaultGuidGenerator>(GuidVersion.V4)
            .AddKeyedTransient<IVGuidGenerator, V7DefaultGuidGenerator>(GuidVersion.V7)
            .AddTransient<IVGuidGeneratorProvider, VGuidGeneratorProvider>()
            .AddTransient<IGuidGenerator, GuidGenerator>();
}