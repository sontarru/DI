namespace Sontar.DI;

/// <summary>
/// Represents a type for retrieving a <see cref="IVGuidGenerator"/> service for a particular <see
/// cref="GuidVersion"/>.
/// </summary>
public interface IVGuidGeneratorProvider
{
    /// <summary>
    /// Gets the <see cref="IVGuidGenerator"/> service for the specified <see cref="GuidVersion"/>.
    /// </summary>
    /// <param name="guidVersion">A <see cref="GuidVersion"/>.</param>
    /// <returns>
    /// A <see cref="IVGuidGenerator"/> object for the <paramref name="guidVersion"/>.
    /// </returns>
    IVGuidGenerator GetGuidGenerator(GuidVersion guidVersion);
}