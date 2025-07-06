namespace Sontar.DI;

/// <summary>
/// Represents <see cref="Guid"/> generator for the particular version of <see cref="Guid"/>.
/// </summary>
public interface IVGuidGenerator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Guid"/> structure.
    /// </summary>
    /// <returns>A new <see cref="Guid"/> object.</returns>
    Guid NewGuid();
}