namespace Sontar.DI;

/// <summary>
/// Aggregates other 'tiny' IConsole* interfaces.
/// </summary>
public interface IConsole : IConsoleText, IConsoleBinary, IConsoleKeyboard
{
}