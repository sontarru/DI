using Sontar.DI;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/>
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds default implementations for <see cref="IConsoleText"/>, <see cref="IConsoleBinary"/>,
    /// and <see cref="IConsoleKeyboard"/>.
    /// </summary>
    /// <param name="services">
    /// The dependency injection container to add the implementations to.
    /// </param>
    /// <returns>The value of <paramref name="services"/>.</returns>
    public static IServiceCollection AddConsole(this IServiceCollection services) =>
        services.AddTransient<IConsoleText, ConsoleAdapter>()
            .AddTransient<IConsoleBinary, ConsoleAdapter>()
            .AddTransient<IConsoleKeyboard, ConsoleAdapter>();
}