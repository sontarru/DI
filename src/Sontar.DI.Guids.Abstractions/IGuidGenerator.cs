namespace Sontar.DI;

/// <summary>
/// Represents a <see cref="Guid"/> generator.
/// </summary>
public interface IGuidGenerator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Guid"/> structure.
    /// </summary>
    /// <param name="guidVersion">The GUID version.</param>
    /// <returns>A new <see cref="Guid"/> object.</returns>
    Guid NewGuid(GuidVersion guidVersion = GuidVersion.V4);
}
