namespace Sontar.DI;

/// <summary>
/// Defines the version of the <see cref="Guid"/> according to the <see
/// href="https://www.rfc-editor.org/rfc/rfc9562.html">RFC 9562</see>.
/// </summary>
public enum GuidVersion
{
    /// <summary>
    /// <see cref="Guid"/> version 4.
    /// </summary>
    V4 = 0,

    /// <summary>
    /// <see cref="Guid"/> version 7.
    /// </summary>
    V7 = 1,
}
