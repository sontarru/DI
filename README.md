# Sontar.DI

Sontar.DI.* is a collection of adapters (wrappers) to some standard .NET library types. It provides
segregation between abstract contracts and implementations so that to help writing code that's more
compliant to the ['Dependency Inversion Principle'](https://en.wikipedia.org/wiki/Dependency_inversion_principle)
of the [SOLID](https://en.wikipedia.org/wiki/SOLID).

Currently it includes the adapters for the
[System.Console](https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-9.0),
[System.Environment](https://learn.microsoft.com/en-us/dotnet/api/system.environment?view=net-9.0)
types, and [System.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid?view=net-9.0)
generation.
