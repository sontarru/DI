using Microsoft.Extensions.DependencyInjection;

namespace Sontar.DI;

internal class VGuidGeneratorProvider : IVGuidGeneratorProvider
{
    private readonly IServiceProvider _serviceProvider;

    public VGuidGeneratorProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IVGuidGenerator GetGuidGenerator(GuidVersion guidVersion) =>
        _serviceProvider.GetRequiredKeyedService<IVGuidGenerator>(guidVersion);
}