# Portable source regressions

Run with .NET 10.0.401 and C# 5:

```sh
dotnet run --project tests/Portable.Tests/Portable.Tests.csproj --configuration Release
```

Links the actual MainPage code. UI/audio classes are inert property-recording adapters. Tests both entrypoints and repeated requests against the documented 0–1 Volume contract, original resource and restart position. This is a property contract regression, not actual playback testing. Reference: https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/ms593081(v=vs.95)

These tests do not build or validate the historical application SDK/device runtime. Original platform targets, dependencies and vendor binaries are unchanged. The .NET harness has no package feeds or external test packages.
