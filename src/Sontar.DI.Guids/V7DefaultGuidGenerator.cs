namespace Sontar.DI;

/// <inheritdoc/>
public sealed class V7DefaultGuidGenerator : IVGuidGenerator
{
    /// <inheritdoc/>
    public Guid NewGuid() => Guid.CreateVersion7();
}