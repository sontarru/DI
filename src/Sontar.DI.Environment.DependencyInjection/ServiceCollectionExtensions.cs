using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/>
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds default implementation for <see cref="IEnvironment"/>.
    /// </summary>
    /// <param name="services">
    /// The dependency injection container to add the implementations to.
    /// </param>
    /// <returns>The value of <paramref name="services"/>.</returns>
    public static IServiceCollection AddEnvironment(this IServiceCollection services) =>
        services.AddTransient<IEnvironment, EnvironmentAdapter>();
}