namespace Sontar.DI;

/// <inheritdoc/>
public sealed class GuidGenerator : IGuidGenerator
{
    private readonly IVGuidGeneratorProvider _vGuidGeneratorProvider;

    /// <summary>
    /// Initialize a new instance of the <see cref="GuidGenerator"/> class.
    /// </summary>
    public GuidGenerator(IVGuidGeneratorProvider vGuidGeneratorProvider)
    {
        _vGuidGeneratorProvider = vGuidGeneratorProvider;
    }

    /// <inheritdoc/>
    public Guid NewGuid(GuidVersion guidVersion = GuidVersion.V4) =>
        _vGuidGeneratorProvider.GetGuidGenerator(guidVersion).NewGuid();
}