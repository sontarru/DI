namespace Sontar.DI;

/// <inheritdoc/>
public sealed class V4DefaultGuidGenerator : IVGuidGenerator
{
    /// <inheritdoc/>
    public Guid NewGuid() => Guid.NewGuid();
}